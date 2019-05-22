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
    public partial class SISMSGSTR0007
    {

        private string numCtrlIFField;

        private byte tpCtDebtdField;

        private byte agDebtdField;

        private uint ctDebtdField;

        private string tpPessoaDebtdField;

        private string nomCliDebtdField;

        private string tpCtCredtdField;

        private string tpPessoaCredtdField;

        private byte vlrLancField;

        private string codIdentdTransfField;

        private string dtMovtoField;

        private string dtAgendtField;

        private string hrAgendtField;

        /// <remarks/>
        public string NumCtrlIF
        {
            get
            {
                return this.numCtrlIFField;
            }
            set
            {
                this.numCtrlIFField = value;
            }
        }

        /// <remarks/>
        public byte TpCtDebtd
        {
            get
            {
                return this.tpCtDebtdField;
            }
            set
            {
                this.tpCtDebtdField = value;
            }
        }

        /// <remarks/>
        public byte AgDebtd
        {
            get
            {
                return this.agDebtdField;
            }
            set
            {
                this.agDebtdField = value;
            }
        }

        /// <remarks/>
        public uint CtDebtd
        {
            get
            {
                return this.ctDebtdField;
            }
            set
            {
                this.ctDebtdField = value;
            }
        }

        /// <remarks/>
        public string TpPessoaDebtd
        {
            get
            {
                return this.tpPessoaDebtdField;
            }
            set
            {
                this.tpPessoaDebtdField = value;
            }
        }

        /// <remarks/>
        public string NomCliDebtd
        {
            get
            {
                return this.nomCliDebtdField;
            }
            set
            {
                this.nomCliDebtdField = value;
            }
        }

        /// <remarks/>
        public string TpCtCredtd
        {
            get
            {
                return this.tpCtCredtdField;
            }
            set
            {
                this.tpCtCredtdField = value;
            }
        }

        /// <remarks/>
        public string TpPessoaCredtd
        {
            get
            {
                return this.tpPessoaCredtdField;
            }
            set
            {
                this.tpPessoaCredtdField = value;
            }
        }

        /// <remarks/>
        public byte VlrLanc
        {
            get
            {
                return this.vlrLancField;
            }
            set
            {
                this.vlrLancField = value;
            }
        }

        /// <remarks/>
        public string CodIdentdTransf
        {
            get
            {
                return this.codIdentdTransfField;
            }
            set
            {
                this.codIdentdTransfField = value;
            }
        }

        /// <remarks/>
        public string DtMovto
        {
            get
            {
                return this.dtMovtoField;
            }
            set
            {
                this.dtMovtoField = value;
            }
        }

        /// <remarks/>
        public string DtAgendt
        {
            get
            {
                return this.dtAgendtField;
            }
            set
            {
                this.dtAgendtField = value;
            }
        }

        /// <remarks/>
        public string HrAgendt
        {
            get
            {
                return this.hrAgendtField;
            }
            set
            {
                this.hrAgendtField = value;
            }
        }
    }


}
