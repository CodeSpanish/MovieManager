using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.Windsor;
using MovieManager.BusinessLogic;

namespace MovieManagerForms
{
    public partial class Main : Form
    {
        private readonly IMovieListController _movieList;

        public Main(IWindsorContainer container)
        {
            InitializeComponent();
            _movieList = container.Resolve<IMovieListController>();
        }

        private void MovieListUpdate_Click(object sender, EventArgs e)
        {
            _movieList.UpadteList();
        }

    }
}
