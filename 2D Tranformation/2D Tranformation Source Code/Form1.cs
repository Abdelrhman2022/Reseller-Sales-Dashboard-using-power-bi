using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace Transformation
{
	
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TrackBar tRotDeg;
		private System.Windows.Forms.Label lblRotDeg;
		private System.Windows.Forms.CheckBox cbRotate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTransX;
		private System.Windows.Forms.TrackBar tTransX;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTransY;
		private System.Windows.Forms.TrackBar tTransY;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblRotY;
		private System.Windows.Forms.TrackBar tRotY;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lblRotX;
		private System.Windows.Forms.TrackBar tRotX;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label lblStrY;
		private System.Windows.Forms.TrackBar tStrY;
		private System.Windows.Forms.CheckBox cbStretch;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblStrX;
		private System.Windows.Forms.TrackBar tStrX;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.CheckBox cbTranslation;
		private System.Windows.Forms.PictureBox pictureBoxBase;
		private System.Windows.Forms.CheckBox cbFlipY;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.CheckBox cbRealtime;
		
		private System.ComponentModel.Container components = null;
        private CheckBox cbShowRegionDemo;
        private CheckBox cbReflectX;
        private CheckBox cbReflectY;
        private Form2 _f2;
		public Form1()
		{
			
			InitializeComponent();

			
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		
		
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tRotDeg = new System.Windows.Forms.TrackBar();
            this.lblRotDeg = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRotate = new System.Windows.Forms.CheckBox();
            this.cbTranslation = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTransX = new System.Windows.Forms.Label();
            this.tTransX = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTransY = new System.Windows.Forms.Label();
            this.tTransY = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRotY = new System.Windows.Forms.Label();
            this.tRotY = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRotX = new System.Windows.Forms.Label();
            this.tRotX = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.lblStrY = new System.Windows.Forms.Label();
            this.tStrY = new System.Windows.Forms.TrackBar();
            this.cbStretch = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblStrX = new System.Windows.Forms.Label();
            this.tStrX = new System.Windows.Forms.TrackBar();
            this.pictureBoxBase = new System.Windows.Forms.PictureBox();
            this.cbFlipY = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbRealtime = new System.Windows.Forms.CheckBox();
            this.cbShowRegionDemo = new System.Windows.Forms.CheckBox();
            this.cbReflectX = new System.Windows.Forms.CheckBox();
            this.cbReflectY = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotDeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTransX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTransY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStrY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStrX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).BeginInit();
            this.SuspendLayout();
           
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
           
            this.button1.Location = new System.Drawing.Point(344, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go";
            this.button1.Click += new System.EventHandler(this.button1_Click);
             
            this.tRotDeg.AutoSize = false;
            this.tRotDeg.LargeChange = 1;
            this.tRotDeg.Location = new System.Drawing.Point(496, 40);
            this.tRotDeg.Maximum = 90;
            this.tRotDeg.Minimum = -90;
            this.tRotDeg.Name = "tRotDeg";
            this.tRotDeg.Size = new System.Drawing.Size(104, 24);
            this.tRotDeg.TabIndex = 2;
            this.tRotDeg.TickFrequency = 30;
            this.tRotDeg.ValueChanged += new System.EventHandler(this.tRotDeg_ValueChanged);
            
            this.lblRotDeg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRotDeg.Location = new System.Drawing.Point(600, 40);
            this.lblRotDeg.Name = "lblRotDeg";
            this.lblRotDeg.Size = new System.Drawing.Size(32, 24);
            this.lblRotDeg.TabIndex = 3;
            
            this.listBox1.Location = new System.Drawing.Point(432, 352);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 56);
            this.listBox1.TabIndex = 4;
             
            this.buttonDown.Location = new System.Drawing.Point(616, 382);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(16, 24);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.Text = "-";
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
             
             
            this.buttonUp.Location = new System.Drawing.Point(616, 352);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(16, 24);
            this.buttonUp.TabIndex = 6;
            this.buttonUp.Text = "+";
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            
            this.label2.Location = new System.Drawing.Point(448, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Degree";
             
            this.cbRotate.Location = new System.Drawing.Point(424, 8);
            this.cbRotate.Name = "cbRotate";
            this.cbRotate.Size = new System.Drawing.Size(80, 16);
            this.cbRotate.TabIndex = 8;
            this.cbRotate.Text = "Rotation";
            this.cbRotate.CheckedChanged += new System.EventHandler(this.cbRotate_CheckedChanged);
            
            this.cbTranslation.Location = new System.Drawing.Point(432, 144);
            this.cbTranslation.Name = "cbTranslation";
            this.cbTranslation.Size = new System.Drawing.Size(88, 16);
            this.cbTranslation.TabIndex = 12;
            this.cbTranslation.Text = "Translation";
            this.cbTranslation.CheckedChanged += new System.EventHandler(this.cbTranslation_CheckedChanged);
             
            this.label3.Location = new System.Drawing.Point(448, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "X";
          
            this.lblTransX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransX.Location = new System.Drawing.Point(600, 176);
            this.lblTransX.Name = "lblTransX";
            this.lblTransX.Size = new System.Drawing.Size(32, 24);
            this.lblTransX.TabIndex = 10;
            
            this.tTransX.AutoSize = false;
            this.tTransX.LargeChange = 1;
            this.tTransX.Location = new System.Drawing.Point(496, 176);
            this.tTransX.Maximum = 150;
            this.tTransX.Minimum = -150;
            this.tTransX.Name = "tTransX";
            this.tTransX.Size = new System.Drawing.Size(104, 24);
            this.tTransX.TabIndex = 9;
            this.tTransX.TickFrequency = 20;
            this.tTransX.ValueChanged += new System.EventHandler(this.tTransX_ValueChanged);
            
            this.label5.Location = new System.Drawing.Point(448, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Y";
            
            this.lblTransY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTransY.Location = new System.Drawing.Point(600, 208);
            this.lblTransY.Name = "lblTransY";
            this.lblTransY.Size = new System.Drawing.Size(32, 24);
            this.lblTransY.TabIndex = 14;
          
            this.tTransY.AutoSize = false;
            this.tTransY.LargeChange = 1;
            this.tTransY.Location = new System.Drawing.Point(496, 208);
            this.tTransY.Maximum = 150;
            this.tTransY.Minimum = -150;
            this.tTransY.Name = "tTransY";
            this.tTransY.Size = new System.Drawing.Size(104, 24);
            this.tTransY.TabIndex = 13;
            this.tTransY.TickFrequency = 20;
            this.tTransY.ValueChanged += new System.EventHandler(this.tTransY_ValueChanged);
           
            this.label9.Location = new System.Drawing.Point(448, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Y";
           
            this.lblRotY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRotY.Location = new System.Drawing.Point(600, 104);
            this.lblRotY.Name = "lblRotY";
            this.lblRotY.Size = new System.Drawing.Size(32, 24);
            this.lblRotY.TabIndex = 22;
            
            this.tRotY.AutoSize = false;
            this.tRotY.LargeChange = 1;
            this.tRotY.Location = new System.Drawing.Point(496, 104);
            this.tRotY.Maximum = 50;
            this.tRotY.Minimum = -50;
            this.tRotY.Name = "tRotY";
            this.tRotY.Size = new System.Drawing.Size(104, 24);
            this.tRotY.TabIndex = 21;
            this.tRotY.TickFrequency = 10;
            this.tRotY.ValueChanged += new System.EventHandler(this.tRotY_ValueChanged);
           
            this.label11.Location = new System.Drawing.Point(448, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "X";
            
            this.lblRotX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRotX.Location = new System.Drawing.Point(600, 72);
            this.lblRotX.Name = "lblRotX";
            this.lblRotX.Size = new System.Drawing.Size(32, 24);
            this.lblRotX.TabIndex = 19;
            
            this.tRotX.AutoSize = false;
            this.tRotX.LargeChange = 1;
            this.tRotX.Location = new System.Drawing.Point(496, 72);
            this.tRotX.Maximum = 50;
            this.tRotX.Minimum = -50;
            this.tRotX.Name = "tRotX";
            this.tRotX.Size = new System.Drawing.Size(104, 24);
            this.tRotX.TabIndex = 18;
            this.tRotX.TickFrequency = 10;
            this.tRotX.ValueChanged += new System.EventHandler(this.tRotX_ValueChanged);
           
            this.label14.Location = new System.Drawing.Point(448, 312);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 24);
            this.label14.TabIndex = 30;
            this.label14.Text = "Y";
            
            this.lblStrY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStrY.Location = new System.Drawing.Point(600, 312);
            this.lblStrY.Name = "lblStrY";
            this.lblStrY.Size = new System.Drawing.Size(32, 24);
            this.lblStrY.TabIndex = 29;
            
            this.tStrY.AutoSize = false;
            this.tStrY.LargeChange = 1;
            this.tStrY.Location = new System.Drawing.Point(496, 312);
            this.tStrY.Maximum = 20;
            this.tStrY.Minimum = 1;
            this.tStrY.Name = "tStrY";
            this.tStrY.Size = new System.Drawing.Size(104, 24);
            this.tStrY.TabIndex = 28;
            this.tStrY.Value = 10;
            this.tStrY.ValueChanged += new System.EventHandler(this.tStrY_ValueChanged);
             
            this.cbStretch.Location = new System.Drawing.Point(432, 248);
            this.cbStretch.Name = "cbStretch";
            this.cbStretch.Size = new System.Drawing.Size(80, 16);
            this.cbStretch.TabIndex = 27;
            this.cbStretch.Text = "Stretch";
            this.cbStretch.CheckedChanged += new System.EventHandler(this.cbStretch_CheckedChanged);
            
            this.label16.Location = new System.Drawing.Point(448, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 26;
            this.label16.Text = "X";
            
            this.lblStrX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStrX.Location = new System.Drawing.Point(600, 280);
            this.lblStrX.Name = "lblStrX";
            this.lblStrX.Size = new System.Drawing.Size(32, 24);
            this.lblStrX.TabIndex = 25;
            
            this.tStrX.AutoSize = false;
            this.tStrX.LargeChange = 1;
            this.tStrX.Location = new System.Drawing.Point(496, 280);
            this.tStrX.Maximum = 20;
            this.tStrX.Minimum = 1;
            this.tStrX.Name = "tStrX";
            this.tStrX.Size = new System.Drawing.Size(104, 24);
            this.tStrX.TabIndex = 24;
            this.tStrX.Value = 10;
            this.tStrX.ValueChanged += new System.EventHandler(this.tStrX_ValueChanged);
            
            this.pictureBoxBase.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBase.Image")));
            this.pictureBoxBase.Location = new System.Drawing.Point(56, 448);
            this.pictureBoxBase.Name = "pictureBoxBase";
            this.pictureBoxBase.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxBase.TabIndex = 32;
            this.pictureBoxBase.TabStop = false;
            this.pictureBoxBase.Visible = false;
         
            this.cbFlipY.Checked = true;
            this.cbFlipY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFlipY.Location = new System.Drawing.Point(16, 424);
            this.cbFlipY.Name = "cbFlipY";
            this.cbFlipY.Size = new System.Drawing.Size(112, 16);
            this.cbFlipY.TabIndex = 33;
            this.cbFlipY.Text = "Flip Y Coordinates";
            this.cbFlipY.CheckedChanged += new System.EventHandler(this.cbFlipY_CheckedChanged);
          
            this.btnReset.Location = new System.Drawing.Point(264, 424);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 24);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
           
            this.cbRealtime.Checked = true;
            this.cbRealtime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRealtime.Location = new System.Drawing.Point(144, 424);
            this.cbRealtime.Name = "cbRealtime";
            this.cbRealtime.Size = new System.Drawing.Size(112, 16);
            this.cbRealtime.TabIndex = 35;
            this.cbRealtime.Text = "Real Time";
            
            this.cbShowRegionDemo.AutoSize = true;
            this.cbShowRegionDemo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbShowRegionDemo.Location = new System.Drawing.Point(541, 424);
            this.cbShowRegionDemo.Name = "cbShowRegionDemo";
            this.cbShowRegionDemo.Size = new System.Drawing.Size(91, 17);
            this.cbShowRegionDemo.TabIndex = 36;
            this.cbShowRegionDemo.Text = "Region Demo";
            this.cbShowRegionDemo.UseVisualStyleBackColor = true;
            this.cbShowRegionDemo.CheckedChanged += new System.EventHandler(this.cbShowRegionDemo_CheckedChanged);
           
            this.cbReflectX.Location = new System.Drawing.Point(679, 1);
            this.cbReflectX.Name = "cbReflectX";
            this.cbReflectX.Size = new System.Drawing.Size(130, 30);
            this.cbReflectX.TabIndex = 37;
            this.cbReflectX.Text = "Refect Along X axis";
            this.cbReflectX.CheckedChanged += new System.EventHandler(this.cbReflectX_CheckedChanged);
            
            this.cbReflectY.Location = new System.Drawing.Point(679, 35);
            this.cbReflectY.Name = "cbReflectY";
            this.cbReflectY.Size = new System.Drawing.Size(130, 25);
            this.cbReflectY.TabIndex = 38;
            this.cbReflectY.Text = "Reflect Along Y axis";
            this.cbReflectY.CheckedChanged += new System.EventHandler(this.cbReflectY_CheckedChanged);
           
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(830, 460);
            this.Controls.Add(this.cbReflectY);
            this.Controls.Add(this.cbReflectX);
            this.Controls.Add(this.cbShowRegionDemo);
            this.Controls.Add(this.cbRealtime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbFlipY);
            this.Controls.Add(this.pictureBoxBase);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblStrY);
            this.Controls.Add(this.tStrY);
            this.Controls.Add(this.cbStretch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblStrX);
            this.Controls.Add(this.tStrX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRotY);
            this.Controls.Add(this.tRotY);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblRotX);
            this.Controls.Add(this.tRotX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTransY);
            this.Controls.Add(this.tTransY);
            this.Controls.Add(this.cbTranslation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTransX);
            this.Controls.Add(this.tTransX);
            this.Controls.Add(this.cbRotate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblRotDeg);
            this.Controls.Add(this.tRotDeg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transformation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotDeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTransX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTransY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStrY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tStrX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}



		private void DrawAxes(Graphics g,bool flipY)
		{
		  
		  
		  Matrix mm=g.Transform;
		
          
		  g.Transform=new Matrix();
		  
	      Pen p=new Pen(Brushes.Red,1);
	  
          Matrix m=new Matrix();

		  
		  m.Translate(200,200);
		  
		  g.Transform=m;

	
		  g.DrawLine(p,-200,0,200,0); 
		  g.DrawLine(p,0,-200,0,200);	

		  
		  for(int i=-150;i<=150;i+=50)
		  {
			
			  if(flipY)
			    g.DrawString(i.ToString(),this.Font,Brushes.Red,5,-i);
		      else
				g.DrawString(i.ToString(),this.Font,Brushes.Red,5,i);
			  
			  
			  g.DrawLine(p,-5,i,5,i);
			  
			  g.DrawLine(p,i,-5,i,5);

		  }


		  m.Rotate(90,MatrixOrder.Prepend);

		  
		  g.Transform=m;

		  for(int i=-150;i<=150;i+=50)
		  {
			 
			  g.DrawString(i.ToString(),this.Font,Brushes.Red,5,-i);
		  }
		  
		  
		  g.Transform=mm;

		}

		private void button1_Click(object sender, System.EventArgs e)
		{

			
			Image img=new Bitmap(400,400);

            
            _f2.BackgroundImage = new Bitmap(400, 400);

			
			pictureBox1.Image=img;
			Graphics g=Graphics.FromImage(pictureBox1.Image);

            
            Graphics g1 = Graphics.FromImage(_f2.BackgroundImage);


			
			DrawAxes(g,(cbFlipY.CheckState==CheckState.Checked));

			
			Matrix mm=new Matrix();

			
			if(cbFlipY.CheckState==CheckState.Checked)
				mm=new Matrix(1,0,0,-1,0,0);
			
			mm.Translate(200,200,MatrixOrder.Append);
			 
			g.Transform  = mm;
            g1.Transform = mm;

			
			Matrix mm1=new Matrix();

	
			for(int i=0;i<listBox1.Items.Count;i++)
			{
			

                if (listBox1.Items[i].ToString() == "ReflectX")
                {
                    Matrix mreflex = new Matrix(1, 0, 0, -1, 0, 0);
                    mm1.Multiply(mreflex, MatrixOrder.Append);
                }

                if (listBox1.Items[i].ToString() == "ReflectY")
                {
                    Matrix mreflex = new Matrix(-1, 0, 0, 1, 0, 0);
                    mm1.Multiply(mreflex, MatrixOrder.Append);
                }

				if(listBox1.Items[i].ToString()=="Rotate")
					mm1.RotateAt(
						(cbFlipY.CheckState==CheckState.Checked? -1:1)*int.Parse(lblRotDeg.Text),
						new Point( int.Parse(lblRotX.Text),
						int.Parse(lblRotY.Text)),
						MatrixOrder.Append);


				if(listBox1.Items[i].ToString()=="Translation")
					mm1.Translate(int.Parse(lblTransX.Text),int.Parse(lblTransY.Text),MatrixOrder.Append);

				if(listBox1.Items[i].ToString()=="Stretch")
					mm1.Scale(float.Parse(lblStrX.Text),float.Parse(lblStrY.Text),MatrixOrder.Append);

			}


			GraphicsPath gp=new GraphicsPath();
           

			Image imgpic=(Image)pictureBoxBase.Image.Clone();
            Image imgpic1 = (Image)pictureBoxBase.Image.Clone();
            Graphics.FromImage(imgpic1).DrawRectangle(new Pen(Color.Red, 3), 0, 0, imgpic1.Width-1, imgpic1.Height-1);

         
            PointF[] psrc;

			if(cbFlipY.CheckState ==CheckState.Checked)
			 psrc=new PointF[]{new Point(0,imgpic.Height),new Point(imgpic.Width,imgpic.Height),new Point(0,0)};
			else
			 psrc=new PointF[]{new Point(0,0),new Point(imgpic.Width,0),new Point(0,imgpic.Height)};
		    
            gp.AddPolygon(psrc);

			
			gp.Transform(mm1);
		
		    PointF[] pts=gp.PathPoints;


			g.DrawImage(imgpic,pts);

        
            g1.DrawImage(imgpic1, pts);
           
	        pictureBox1.Refresh();


            
            GraphicsPath gp1 = new GraphicsPath();
           
            PointF[] psrc1 = new PointF[] { new Point(0, 0), new Point(imgpic.Width, 0), new Point(imgpic.Width, imgpic.Height), new Point(0, imgpic.Height) };
            gp1.AddPolygon(psrc1);

            
            mm1.Multiply(mm,MatrixOrder.Append);

            
            gp1.Transform(mm1);
            _f2.Region=new Region (gp1);
            if (_f2.Visible) _f2.Refresh();
	
		}

		private void tRotDeg_ValueChanged(object sender, System.EventArgs e)
		{
			lblRotDeg.Text =tRotDeg.Value.ToString() ;
			cbRotate.CheckState=CheckState.Checked;
			if(cbRealtime.CheckState ==CheckState.Checked)
			{
				button1_Click(sender,null);
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{  
            //region demo
            _f2 = new Form2();
            _f2.TopMost = true;
            cbShowRegionDemo_CheckedChanged(null, null);

			tRotDeg.Value=0;
			tRotX.Value=0;
			tRotY.Value=0;

			lblRotDeg.Text=tRotDeg.Value.ToString();
			lblRotX.Text=tRotX.Value.ToString();
			lblRotY.Text=tRotY.Value.ToString();

			tTransX.Value =0;
			tTransY.Value=0;

			lblTransX.Text=tTransX.Value.ToString();
			lblTransY.Text=tTransY.Value.ToString();

			tStrX.Value =10;
			tStrY.Value =10;

			lblStrX.Text=String.Format("{0:0.0}",(tStrX.Value /10.0));
			lblStrY.Text=String.Format("{0:0.0}",(tStrY.Value/10.0));

			cbFlipY.CheckState=CheckState.Checked;
			cbRotate.CheckState=CheckState.Unchecked;
			cbTranslation.CheckState=CheckState.Unchecked;
			cbStretch.CheckState =CheckState.Unchecked;

			button1_Click(this,null);

		}

		private void buttonDown_Click(object sender, System.EventArgs e)
		{
			int index=listBox1.SelectedIndex;
			if (index>=listBox1.Items.Count-1)return;
			if ((index)<=-1 )return;
			string s=(string)listBox1.Items[index];
			listBox1.Items.RemoveAt(index);
			listBox1.Items.Insert(index+1,s);
			listBox1.SelectedIndex=index+1;
			if(cbRealtime.CheckState ==CheckState.Checked)
			{
				button1_Click(sender,null);
			}
		}

		private void buttonUp_Click(object sender, System.EventArgs e)
		{
			int index=listBox1.SelectedIndex;
			if ((index)<=0 )return;
			string s=(string)listBox1.Items[index];
			listBox1.Items.RemoveAt(index);
			listBox1.Items.Insert(index-1,s);
			listBox1.SelectedIndex=index-1;	
			if(cbRealtime.CheckState ==CheckState.Checked)
			{
				button1_Click(sender,null);
			}

		}

		private void UpdateListBox(CheckBox cb, String s)
		{
			if (cb.CheckState==CheckState.Checked)
			{
				bool found=false;
				for(int i=0;i<listBox1.Items.Count;i++)
					if(listBox1.Items[i].ToString()==s)
					{
						found=true;
						break;
					}

				if (!found)
				{
					listBox1.Items.Add(s);
					listBox1.SelectedIndex=listBox1.Items.Count-1;
				}
		
			}
			else
			{
				for(int i=0;i<listBox1.Items.Count;i++)
				{
					if(listBox1.Items[i].ToString()==s)
					{
						listBox1.Items.RemoveAt(i);

						if(i>0) listBox1.SelectedIndex=i-1;
						if(i==0)
							if(listBox1.Items.Count>=1)
								listBox1.SelectedIndex=0;

						break;
					}
				}
			}
		}

		private void cbRotate_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateListBox((CheckBox) sender,"Rotate");
		}

		private void cbTranslation_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateListBox((CheckBox) sender,"Translation");
		}

		private void cbStretch_CheckedChanged(object sender, System.EventArgs e)
		{
			UpdateListBox((CheckBox) sender,"Stretch");
		}

		private void tRotX_ValueChanged(object sender, System.EventArgs e)
		{
			lblRotX.Text =tRotX.Value.ToString() ;
			cbRotate.CheckState=CheckState.Checked;
			if(cbRealtime.CheckState ==CheckState.Checked)
			{
				button1_Click(sender,null);
			}
		}

		private void tRotY_ValueChanged(object sender, System.EventArgs e)
		{
			lblRotY.Text =tRotY.Value.ToString() ;
			cbRotate.CheckState=CheckState.Checked;
			if(cbRealtime.CheckState ==CheckState.Checked)
			{
				button1_Click(sender,null);
			}
		}

		private void tTransX_ValueChanged(object sender, System.EventArgs e)
		{
			lblTransX.Text =tTransX.Value.ToString() ;
			cbTranslation.CheckState=CheckState.Checked;
			if(cbRealtime.CheckState ==CheckState.Checked)
			{
				button1_Click(sender,null);
			}
		}

		private void tTransY_ValueChanged(object sender, System.EventArgs e)
		{
		    lblTransY.Text =tTransY.Value.ToString() ;
			cbTranslation.CheckState=CheckState.Checked;
			if(cbRealtime.CheckState ==CheckState.Checked)
			{
				button1_Click(sender,null);
			}
		}

		private void tStrX_ValueChanged(object sender, System.EventArgs e)
		{
			lblStrX.Text=String.Format("{0:0.0}",(tStrX.Value /10.0));
			cbStretch.CheckState=CheckState.Checked;
			if(cbRealtime.CheckState ==CheckState.Checked)
			{
				button1_Click(sender,null);
			}
		}

		private void tStrY_ValueChanged(object sender, System.EventArgs e)
		{
			lblStrY.Text=String.Format("{0:0.0}",(tStrY.Value/10.0));
			cbStretch.CheckState=CheckState.Checked;
			if(cbRealtime.CheckState ==CheckState.Checked)
			{
				button1_Click(sender,null);
			}
		}

		private void cbFlipY_CheckedChanged(object sender, System.EventArgs e)
		{
		  button1_Click(sender,null);
		}

		private void btnReset_Click(object sender, System.EventArgs e)
		{
          _f2.Close();
		  Form1_Load(sender,null);

		}

        private void cbShowRegionDemo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
              
                Rectangle rt = this.RectangleToScreen(new Rectangle(pictureBox1.Left, pictureBox1.Top, pictureBox1.Width, pictureBox1.Height));

           
            }catch
            {
            }
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            cbShowRegionDemo_CheckedChanged(null, null);
        }

        private void cbReflectX_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox((CheckBox)sender, "ReflectX");
            if (cbRealtime.CheckState == CheckState.Checked)
            {
                button1_Click(sender, null);
            }
        }

        private void cbReflectY_CheckedChanged(object sender, EventArgs e)
        {
            UpdateListBox((CheckBox)sender, "ReflectY");
            if (cbRealtime.CheckState == CheckState.Checked)
            {
                button1_Click(sender, null);
            }

        }


	}
}
