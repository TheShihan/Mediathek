using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace BusinessLogic.Common
{
    /// <summary>
    /// Various static helper methods
    /// </summary>
    public static class Helper
    {
        #region Fields

        /// <summary>
        /// Business logic handler instance
        /// </summary>
        private static BusinessLogicHandler bl = new BusinessLogicHandler();

        #endregion

        /// <summary>
        /// Fill the TreeView with categories (of the current media type).
        /// (Only works with WEB treeviews)
        /// </summary>
        public static void FillCategories(System.Windows.Forms.TreeView tv, int typeId)
        {
            Category mainCat = bl.GetCategoryById(typeId);

            // add root node to treeview
            System.Windows.Forms.TreeNode tn =
                new System.Windows.Forms.TreeNode(mainCat.Name, mainCat.CategoryId, mainCat.CategoryId);
            tv.Nodes.Add(tn);

            // add childs
            AddChildCategories(tn, mainCat.CategoryId);
        }

        /// <summary>
        /// Add child nodes (categories) to a given treenode
        /// (Only works with web treenodes)
        /// </summary>
        /// <param name="tn">The tree node to which the children are added</param>
        /// <param name="parentCatId">The ID of the category of the parent node</param>
        public static void AddChildCategories(System.Windows.Forms.TreeNode tn, int parentCatId)
        {
            List<Category> cats =
                bl.GetCategoriesByParentId(parentCatId);

            cats.Sort();

            foreach (Category cat in cats)
            {
                System.Windows.Forms.TreeNode tnChild =
                    new System.Windows.Forms.TreeNode(cat.Name, cat.CategoryId, cat.CategoryId);
                tn.Nodes.Add(tnChild);

                // recursion to add the children of this child node
                AddChildCategories(tnChild, cat.CategoryId);
            }
        }

        /// <summary>
        /// Creates an image out of a byte array
        /// </summary>
        /// <param name="imgData">The byte array</param>
        /// <returns>Image object</returns>
        public static Image CreateImageFromByteArray(byte[] imgData)
        {
            MemoryStream ms = new MemoryStream(imgData);
            return Image.FromStream(ms);
        }

        /// <summary>
        /// Creates a byte array out of an image
        /// </summary>
        /// <param name="image">The image</param>
        /// <param name="imgFormat">The image format of the image</param>
        /// <returns>Byte array representing image</returns>
        public static byte[] CreateByteArrayFromImage(Image image, ImageFormat imgFormat)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, imgFormat);
            return ms.ToArray();
        }

    }
}
