using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace AAA380_Loja_Web_services
{
    [DataContract]
    public class MediaResponse

    {



        private Double media;

        private String resultado;



        [DataMember]
        public Double Media

        {

            get { return media; }

            set { media = value; }

        }



        [DataMember]
        public String Resultado

        {

            get { return resultado; }

            set { resultado = value; }

        }
    }
  }