
using AplXafNux.Module.Enumerados;
using AplXafNux.Module.BusinessObjects.Catalogo;
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

namespace AplXafNux.Module.BusinessObjects.Pruebas
{
    [DefaultClassOptions]
    [NavigationItem("Pruebas")] // Nombre de la pestaña que queramos que salga
        [XafDisplayName("PELICULAS")]

        [DefaultProperty("Titulo")] 
        //Tiene que ser publica y la exporta para que se utilice en un reporte


        //[ImageName("BO_Contact")]
        //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
        //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
        //[Persistent("DatabaseTableName")]
        // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
        public class Peliculas : BaseObject //(Para numerica y si no te dicen nada) // XPObject
        { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
            // Use CodeRush to create XPO classes and properties with a few keystrokes.
            // https://docs.devexpress.com/CodeRushForRoslyn/118557
            public Peliculas(Session session)
                : base(session)
            {
            }

            /*
            public override void AfterConstruction()
            {
                base.AfterConstruction();
                // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
            }
            */
            // descomentas con Ctr+k+u 
            /*
            private string _PersistentProperty;
            [XafDisplayName("My display name"), ToolTip("My hint message")]
            //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
            //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
            public string PersistentProperty
            {
                get { return _PersistentProperty; }
                set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
            }
            */
            #region Propiedades
            private string _Titulo;
            [XafDisplayName("Titulo"), ToolTip("Titulo de la pelicula")]
            [RuleRequiredField]
            public string Titulo {
                get { return _Titulo;}
                set { SetPropertyValue(nameof(Titulo), ref _Titulo, value); }
            }
            private string _Sinopsis;
            [XafDisplayName("Sinopsis"), ToolTip("Sinoposis de la pelicula")]
            [Size(500)]
            public string Sinopsis
            {
                get { return _Sinopsis; }
                set { SetPropertyValue(nameof(Titulo), ref _Sinopsis, value); }
            }
            private double _Precio;
            [XafDisplayName("Precio"), ToolTip("Precio de la pelicula")]
            public double Precio {
                get { return _Precio;}
                set { SetPropertyValue(nameof(Precio), ref _Precio, value); }
            }
            private DateTime _FechaDePublicacion;
            [XafDisplayName("Fecha"), ToolTip("Fecha de publicacion")]
            [VisibleInListView(false)]
            public DateTime FechaDePublicacion
            {
                get { return _FechaDePublicacion; }
                set { SetPropertyValue(nameof(FechaDePublicacion), ref _FechaDePublicacion, value); }
            }

        private bool _Visible;
            [XafDisplayName("Visible")]
            public bool Visible
            {
                get { return _Visible; }
                set { SetPropertyValue(nameof(Visible), ref _Visible, value); }
            }

        private FileData _Pelicula;
        [XafDisplayName("Pelicula"), ToolTip("Archivo de la pelicula")]
        [VisibleInListView(false)]
        public FileData Pelicula
        {
            get { return _Pelicula; }
            set { SetPropertyValue(nameof(Pelicula), ref _Pelicula, value); }
        }

        #endregion

        #region Asociaciones
        private CAT_GENEROS_PELICULAS _Cat_Genero;
        [XafDisplayName("Genero"), ToolTip("Genero de la pelicula")]
        [DataSourceCriteria("Visible = true")] // se pone para poder seleccionar y deseleccionar
        public CAT_GENEROS_PELICULAS Cat_Genero
        {
            get { return _Cat_Genero; }
            set { SetPropertyValue(nameof(Cat_Genero), ref _Cat_Genero, value); }
        }

        private EN_TIPO_PELICULA _TipoDePelicula;
        [XafDisplayName("TipoDePelicula")]
        public EN_TIPO_PELICULA TipoDePelicula
        {
            get { return _TipoDePelicula; }
            set { SetPropertyValue(nameof(TipoDePelicula), ref _TipoDePelicula, value); }
        }

        #endregion

        #region Metodos
        public override void AfterConstruction()
            {
                base.AfterConstruction();
                this.Visible = true;
                // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
            }
        /*
            [Action(Caption = "Visible/Invisible", ConfirmationMessage = "¿Estas seguro?", AutoCommit = true)] //, ImageName = "Attention"
            public void Visibilidad() {
                // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
                this.Visible = !this.Visible;
                //this.PersistentProperty = "Paid";
            }
        */
        #endregion



    }
}