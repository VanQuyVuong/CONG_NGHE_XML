using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tuan5_QuyVuong
{
    public   class Labrary
    {
        public XDocument open(string url)
        {
            //Hầm load một file xml vào đối tượng XDocument
            try
            {
                return XDocument.Load(url);
            }
            catch
            {
                return null;
            }
        }

        public void insert(string scode, string sname, string sclass, string saddress, string path)
        {
            XDocument doc = open(path);
            doc.Descendants("ute").Elements("student").Last().AddAfterSelf(new XElement("student",
                                                             new XAttribute("code", scode),
                                                             new XAttribute("name", sname),
                                                             new XAttribute("class", sclass),
                                                             new XAttribute("address", saddress)
                                                             ));
            doc.Save(path);

        }

        public void update(string scode, string sname, string sclass, string saddress, string path)
        {
            XDocument doc = open(path);

            if (doc.Descendants("student").Where(x => x.Attribute("code").Value.Equals(scode)).Count() == 1)
            {
                //Nếu đã tồn tại sản phẩm có ID này rồi thì thực hiện cập nhật
                XElement ele = doc.Descendants("student").Where(x => x.Attribute("code").Value.Equals(scode)).First();
                ele.SetAttributeValue("name", sname);
                ele.SetAttributeValue("class", sclass);
                ele.SetAttributeValue("address", saddress);

            }

            doc.Save(path);

        }


        public XElement find(string scode, string path)
        {
            XDocument doc = open(path);

            var list = doc.Root.Nodes();

            foreach (XElement el in list)
            {
                if (scode == el.Attribute("code").Value)
                {
                    return el;


                }

            }

            return null;


        }   // end of method

        public bool delete(string scode, string path)
        {
            XDocument doc = open(path);

            var list = doc.Root.Nodes();

            foreach (XElement el in list)
            {
                if (scode == el.Attribute("code").Value)
                {
                    // el.RemoveAll();
                    el.Remove();
                    doc.Save(path);

                    // el.Element("student").Remove(); sai
                    // el.Element("student").RemoveNodes(); 

                    return true;
                }

            }

            return false;

        }   // end of method
    }
}
