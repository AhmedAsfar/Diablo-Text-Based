using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_TextBased
{
    class ItemParent
    {
        string ItemName;
        public string ItemUse;
        public string ItemDrop;
        public string ItemExamine;

        public string getItemName { get => ItemName; }
        public string getItemUse { get => ItemUse; }
        public string getItemExamine { get => ItemExamine; }
    }
}
