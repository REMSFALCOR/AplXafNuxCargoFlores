using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace AplXafNux.Module.BusinessObjects.Catalogo
{
    [DefaultClassOptions]
    [NavigationItem("Catalogos")]
    //lo que se desplaza del menu del displeymen
    [XafDisplayName("Generos peliculas")]
    [DefaultProperty("Genero")]

    public class CAT_GENEROS_PELICULAS : BaseObject
    { 
        public CAT_GENEROS_PELICULAS(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _Genero;
        [XafDisplayName("Genero"), ToolTip("Genero de la pelicula")]
        [RuleRequiredField]
        public string Genero
        {
            get { return _Genero; }
            set { SetPropertyValue(nameof(Genero), ref _Genero, value); }
        }

        private bool _Visible;
        [XafDisplayName("Visible"), ToolTip("Visible de la pelicula")]
        public bool Visible
        {
            get { return _Visible; }
            set { SetPropertyValue(nameof(Visible), ref _Visible, value); }
        }
    }
}