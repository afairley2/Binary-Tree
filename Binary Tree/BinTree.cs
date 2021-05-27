using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class BinTree
    {
        public class BSTNode
        {
            public int value;
            public BSTNode auxRoot;
            public BSTNode Left;
            public BSTNode Right;

            public BSTNode(int v)
            {
                value = v;
                Left = null;
                Right = null;
            }
            public void insert(BSTNode N)
            {
                if (N.value < this.value)
                {
                    if (Left == null)
                    {
                        Left = N;
                    }
                    else
                    {
                        Left.insert(N);
                    }
                }

                else
                {
                    if (Right == null)
                    {
                        Right = N;
                    }
                    else
                    {

                        Right.insert(N);
                    }
                }

              bool removedNode(int value)

                {
                   
                    if (auxRoot == null)
                        return false;
                    else
                    {
                        if (auxRoot.value == value )
                        {
                            BSTNode auxRoot;
                            auxRoot = Left ;                         

                            BSTNode removedNode = auxRoot.remove(value, auxRoot);
                            auxRoot = auxRoot.Left;

                        }
                    }
                }
         
            }

            private BSTNode remove(int value, BSTNode auxRoot)
            {
                throw new NotImplementedException();
            }
        }
                    
                
                        
                   
                
            
                    
            




           public int count;
           public BSTNode Root;       


            public BinTree()
            {
                count = 0;
                Root = null;
            }
            public void insert(int V)
            {
                BSTNode N = new BSTNode(V);
                if (Root == null)
                {

                    Root = N;
                }
                else
                {
                    Root.insert(N);
                }
                count++;
            }


        }

    }

