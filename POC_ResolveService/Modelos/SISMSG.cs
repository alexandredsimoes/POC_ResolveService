using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_ResolveService.Modelos
{

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "SISMSG")]
    public class SisMsg
    {

        private SISMSGSEGCAB sEGCABField;

        private SISMSGSTR0007 sTR0007Field;

        private SISMSGSTR0008 sTR0008Field;

        /// <remarks/>
        public SISMSGSEGCAB SEGCAB
        {
            get
            {
                return this.sEGCABField;
            }
            set
            {
                this.sEGCABField = value;
            }
        }

        /// <remarks/>
        public SISMSGSTR0007 STR0007
        {
            get
            {
                return this.sTR0007Field;
            }
            set
            {
                this.sTR0007Field = value;
            }
        }

        public SISMSGSTR0008 STR0008
        {
            get
            {
                return this.sTR0008Field;
            }
            set
            {
                this.sTR0008Field = value;
            }
        }
    }

}
