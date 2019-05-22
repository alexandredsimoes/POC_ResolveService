using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_ResolveService.Modelos
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SISMSGSEGCAB
    {

        private string cD_LEGADOField;

        private string tP_MANUTField;

        private string cD_STATUSField;

        private string nR_OPERACAOField;

        private string fL_DEB_CREDField;

        /// <remarks/>
        public string CD_LEGADO
        {
            get
            {
                return this.cD_LEGADOField;
            }
            set
            {
                this.cD_LEGADOField = value;
            }
        }

        /// <remarks/>
        public string TP_MANUT
        {
            get
            {
                return this.tP_MANUTField;
            }
            set
            {
                this.tP_MANUTField = value;
            }
        }

        /// <remarks/>
        public string CD_STATUS
        {
            get
            {
                return this.cD_STATUSField;
            }
            set
            {
                this.cD_STATUSField = value;
            }
        }

        /// <remarks/>
        public string NR_OPERACAO
        {
            get
            {
                return this.nR_OPERACAOField;
            }
            set
            {
                this.nR_OPERACAOField = value;
            }
        }

        /// <remarks/>
        public string FL_DEB_CRED
        {
            get
            {
                return this.fL_DEB_CREDField;
            }
            set
            {
                this.fL_DEB_CREDField = value;
            }
        }
    }
}
