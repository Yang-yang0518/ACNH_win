using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACNH_win.Assets
{
	public class DoubleBufferedPanel:Panel
	{
		public DoubleBufferedPanel()
		{
			this.DoubleBuffered = true;
			this.ResizeRedraw = true;
		}
	}
}
