using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheAnimal
{

    class BinaryTreeRoot
    {
        ChildBinaryTreeNode inputRoot;
        public BinaryTreeRoot(string strQuestion, string strYes,
            string strNo)
        {

            inputRoot = new ChildBinaryTreeNode(strQuestion);

            inputRoot.StoreYes(new ChildBinaryTreeNode(strYes));
            inputRoot.StoreNo(new ChildBinaryTreeNode(strNo));

        }
        public void Play()
        {
            inputRoot.Guess();
        }
    }
}
