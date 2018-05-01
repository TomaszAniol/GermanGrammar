using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Niemiecki
{
    class ItemsToRemove
    {
        private string allText;
        private string[] allTextInTable;
        private string[] allTextInTableOld;
        private string[] wordsToCorrect;

        private void LoadWordsToCorrect()
        {
            string result = "";
            StreamReader sr = new StreamReader("read.txt");
            while (!sr.EndOfStream)
            {
                result += sr.ReadLine();
            }
            result = result.Trim();
            wordsToCorrect = result.Split(new char[] { ' ' });
            sr.Close();
        }

        public ItemsToRemove(string allText)
        {
            this.allText = allText;
            LoadWordsToCorrect();
        }

        public void CheckText(string allText)
        {
            this.allText = allText;
            SplitText();
            CompareTable();
        }

        public void RemoveText()
        {
            SplitText();
            CreateTableCopy();
            SearchAllCharacters();
        }

        private void SplitText()
        {
            allTextInTable = allText.Split(new char[] { ' ' });           
            
        }

        private void CreateTableCopy()
        {
            allTextInTableOld = new string[allTextInTable.Length];
            Array.Copy(allTextInTable, allTextInTableOld, allTextInTable.Length);
        }

        private void SearchAllCharacters()
        {
            for (int i = 0; i < allTextInTable.Length; i++)
            {
                RemoveAllCharacters(i);
            }
        }

        private void RemoveAllCharacters(int i)
        {
            foreach (string word in wordsToCorrect)
            {
                if (allTextInTable[i].ToLower() == word)
                {
                    allTextInTable[i] = "......";
                }
            }

        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < allTextInTable.Length; i++)
            {
                result += allTextInTable[i] + " ";
            }

            result = result.Trim();
            return result;
        }

        private void CompareTable()
        {
            for (int i = 0; i < allTextInTable.Length; i++)
            {
                if (!allTextInTable[i].Equals(allTextInTableOld[i]))
                {
                    allTextInTable[i] = allTextInTable[i] + " (" + allTextInTableOld[i] + ") ";
                }
            }
        }
    }
}
