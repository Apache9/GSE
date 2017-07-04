using System;
using System.IO;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GSE
{
    class SaveFile : IListSource
    {
        private const int stageOffset = 2;

        private const int moneyOffset = 166;

        private static readonly byte[] memberPrefix = new byte[] { 0xA1, 0x40, 0xA1, 0x40, 0xA1, 0x40, 0xA1, 0x40 };

        private string fileName;

        private byte[] content;

        private uint stage;

        private uint money;

        private readonly IList<Member> members = new List<Member>();

        public SaveFile(string fileName)
        {
            this.fileName = fileName;
            Reload();
        }

        public uint Money { get => money; set => money = value; }

        public uint Stage { get => stage + 1; set => stage = value - 1; }

        internal IList<Member> Members => members;

        public bool ContainsListCollection => throw new NotImplementedException();

        private bool MatchMemberPrefix(int offset)
        {
            for (int i = 0; i < memberPrefix.Length; i++)
            {
                if (content[offset + i] != memberPrefix[i])
                {
                    return false;
                }
            }
            return true;
        }

        public void Reload()
        {
            content = File.ReadAllBytes(fileName);
            stage = content[stageOffset];
            money = BitConverter.ToUInt32(content, moneyOffset);
            Members.Clear();
            for (int offset = 0, index = 0; ;)
            {
                while (!MatchMemberPrefix(offset) && offset + memberPrefix.Length < content.Length)
                {
                    offset++;
                }
                if (offset + memberPrefix.Length >= content.Length)
                {
                    break;
                }
                offset += memberPrefix.Length;
                while (content[offset] == 0xA1 && content[offset + 1] == 0x40)
                {
                    offset += 2;
                }
                Members.Add(new Member(content, index, offset));
                offset += 100;
                index++;
            }
        }

        public void Save()
        {
            content[stageOffset] = (byte)stage;
            WriteInt(money, moneyOffset);
            foreach (Member member in members) {
                member.WriteTo(content);
            }
            string tmpFile = Path.GetTempFileName();
            File.WriteAllBytes(tmpFile, content);
            string backupFile = fileName + ".bak";
            if (File.Exists(backupFile))
            {
                File.Delete(backupFile);
            }
            File.Move(fileName, backupFile);
            File.Move(tmpFile, fileName);
        }
        private void WriteInt(uint value, int offset)
        {
            content[offset] = (byte)value;
            content[offset + 1] = (byte)(value >> 8);
            content[offset + 2] = (byte)(value >> 16);
            content[offset + 3] = (byte)(value >> 24);
        }

        public IList GetList()
        {
            return (IList)members;
        }

        public void ExpMax()
        {
            foreach (Member member in members)
            {
                member.ExpMax();
            }
        }
    }

    class Member
    {
        private static readonly uint[] upgradeExp = LoadUpgradeExp();

        private const int levelOffset = 13;

        private const int expOffset = 15;

        private readonly int offset;

        private readonly int index;

        private uint level;

        private uint exp;

        private static uint[] LoadUpgradeExp()
        {
            string[] lines = File.ReadAllLines("UpgradeExp.txt");
            uint[] exps = new uint[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                exps[i] = UInt32.Parse(lines[i]);
            }
            return exps;
        }

        public Member(byte[] content, int index, int offset)
        {
            this.offset = offset;
            this.index = index;
            this.level = BitConverter.ToUInt16(content, offset + levelOffset);
            this.exp = BitConverter.ToUInt16(content, offset + expOffset);
        }

        public uint Level { get => level; set => level = value; }
        public uint Exp { get => exp; set => exp = value; }
        public int Index { get => index; }

        private void WriteInt16(byte[] content, uint value, int offset)
        {
            content[this.offset + offset] = (byte)value;
            content[this.offset + offset + 1] = (byte)(value >> 8);
        }

        public void WriteTo(byte[] content)
        {
            WriteInt16(content, level, levelOffset);
            WriteInt16(content, exp, expOffset);
        }

        public void ExpMax()
        {
            exp = upgradeExp[level - 1] - 1;
        }
    }
}
