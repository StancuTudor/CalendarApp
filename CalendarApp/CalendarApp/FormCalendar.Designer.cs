using CalendarApp.CustomControls;

namespace CalendarApp
{
    partial class FormCalendar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMonday = new Label();
            lblTuesday = new Label();
            lblWednesday = new Label();
            lblThursday = new Label();
            lblFriday = new Label();
            lblSaturday = new Label();
            lblSunday = new Label();
            listView1 = new ScrollingListView();
            listView2 = new ScrollingListView();
            listView3 = new ScrollingListView();
            listView4 = new ScrollingListView();
            listView5 = new ScrollingListView();
            listView6 = new ScrollingListView();
            listView7 = new ScrollingListView();
            listView8 = new ScrollingListView();
            listView9 = new ScrollingListView();
            listView10 = new ScrollingListView();
            listView11 = new ScrollingListView();
            listView12 = new ScrollingListView();
            listView13 = new ScrollingListView();
            listView14 = new ScrollingListView();
            listView15 = new ScrollingListView();
            listView16 = new ScrollingListView();
            listView17 = new ScrollingListView();
            listView18 = new ScrollingListView();
            listView19 = new ScrollingListView();
            listView20 = new ScrollingListView();
            listView21 = new ScrollingListView();
            listView22 = new ScrollingListView();
            listView23 = new ScrollingListView();
            listView24 = new ScrollingListView();
            listView25 = new ScrollingListView();
            listView26 = new ScrollingListView();
            listView27 = new ScrollingListView();
            listView28 = new ScrollingListView();
            listView29 = new ScrollingListView();
            listView30 = new ScrollingListView();
            listView31 = new ScrollingListView();
            listView32 = new ScrollingListView();
            listView33 = new ScrollingListView();
            listView34 = new ScrollingListView();
            listView35 = new ScrollingListView();
            listView36 = new ScrollingListView();
            listView37 = new ScrollingListView();
            listView38 = new ScrollingListView();
            listView39 = new ScrollingListView();
            listView40 = new ScrollingListView();
            listView41 = new ScrollingListView();
            listView42 = new ScrollingListView();
            pnlDays = new Panel();
            dtpMonth = new DateTimePicker();
            btnPreviousMonth = new Button();
            btnNextMonth = new Button();
            pnlConfig = new Panel();
            dgvConfig = new DataGridView();
            btnRefresh = new Button();
            chkShowConfig = new CheckBox();
            pnlDays.SuspendLayout();
            pnlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConfig).BeginInit();
            SuspendLayout();
            // 
            // lblMonday
            // 
            lblMonday.AutoSize = true;
            lblMonday.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonday.Location = new Point(17, 4);
            lblMonday.Name = "lblMonday";
            lblMonday.Size = new Size(63, 20);
            lblMonday.TabIndex = 35;
            lblMonday.Text = "Monday";
            // 
            // lblTuesday
            // 
            lblTuesday.AutoSize = true;
            lblTuesday.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTuesday.Location = new Point(113, 4);
            lblTuesday.Name = "lblTuesday";
            lblTuesday.Size = new Size(63, 20);
            lblTuesday.TabIndex = 36;
            lblTuesday.Text = "Tuesday";
            // 
            // lblWednesday
            // 
            lblWednesday.AutoSize = true;
            lblWednesday.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWednesday.Location = new Point(198, 4);
            lblWednesday.Name = "lblWednesday";
            lblWednesday.Size = new Size(85, 20);
            lblWednesday.TabIndex = 37;
            lblWednesday.Text = "Wednesday";
            // 
            // lblThursday
            // 
            lblThursday.AutoSize = true;
            lblThursday.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThursday.Location = new Point(301, 4);
            lblThursday.Name = "lblThursday";
            lblThursday.Size = new Size(68, 20);
            lblThursday.TabIndex = 38;
            lblThursday.Text = "Thursday";
            // 
            // lblFriday
            // 
            lblFriday.AutoSize = true;
            lblFriday.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFriday.Location = new Point(597, 4);
            lblFriday.Name = "lblFriday";
            lblFriday.Size = new Size(57, 20);
            lblFriday.TabIndex = 41;
            lblFriday.Text = "Sunday";
            // 
            // lblSaturday
            // 
            lblSaturday.AutoSize = true;
            lblSaturday.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaturday.Location = new Point(496, 4);
            lblSaturday.Name = "lblSaturday";
            lblSaturday.Size = new Size(67, 20);
            lblSaturday.TabIndex = 40;
            lblSaturday.Text = "Saturday";
            // 
            // lblSunday
            // 
            lblSunday.AutoSize = true;
            lblSunday.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSunday.Location = new Point(406, 4);
            lblSunday.Name = "lblSunday";
            lblSunday.Size = new Size(49, 20);
            lblSunday.TabIndex = 39;
            lblSunday.Text = "Friday";
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(90, 91);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Scrolled += listView_Scrolled;
            // 
            // listView2
            // 
            listView2.Location = new Point(99, 27);
            listView2.Name = "listView2";
            listView2.Size = new Size(90, 91);
            listView2.TabIndex = 45;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.Scrolled += listView_Scrolled;
            // 
            // listView3
            // 
            listView3.Location = new Point(195, 27);
            listView3.Name = "listView3";
            listView3.Size = new Size(90, 91);
            listView3.TabIndex = 46;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            listView3.Scrolled += listView_Scrolled;
            // 
            // listView4
            // 
            listView4.Location = new Point(291, 27);
            listView4.Name = "listView4";
            listView4.Size = new Size(90, 91);
            listView4.TabIndex = 47;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            listView4.Scrolled += listView_Scrolled;
            // 
            // listView5
            // 
            listView5.Location = new Point(387, 27);
            listView5.Name = "listView5";
            listView5.Size = new Size(90, 91);
            listView5.TabIndex = 48;
            listView5.UseCompatibleStateImageBehavior = false;
            listView5.View = View.Details;
            listView5.Scrolled += listView_Scrolled;
            // 
            // listView6
            // 
            listView6.Location = new Point(483, 27);
            listView6.Name = "listView6";
            listView6.Size = new Size(90, 91);
            listView6.TabIndex = 49;
            listView6.UseCompatibleStateImageBehavior = false;
            listView6.View = View.Details;
            listView6.Scrolled += listView_Scrolled;
            // 
            // listView7
            // 
            listView7.Location = new Point(579, 27);
            listView7.Name = "listView7";
            listView7.Size = new Size(90, 91);
            listView7.TabIndex = 50;
            listView7.UseCompatibleStateImageBehavior = false;
            listView7.View = View.Details;
            listView7.Scrolled += listView_Scrolled;
            // 
            // listView8
            // 
            listView8.Location = new Point(3, 124);
            listView8.Name = "listView8";
            listView8.Size = new Size(90, 91);
            listView8.TabIndex = 51;
            listView8.UseCompatibleStateImageBehavior = false;
            listView8.View = View.Details;
            listView8.Scrolled += listView_Scrolled;
            // 
            // listView9
            // 
            listView9.Location = new Point(99, 124);
            listView9.Name = "listView9";
            listView9.Size = new Size(90, 91);
            listView9.TabIndex = 52;
            listView9.UseCompatibleStateImageBehavior = false;
            listView9.View = View.Details;
            listView9.Scrolled += listView_Scrolled;
            // 
            // listView10
            // 
            listView10.Location = new Point(195, 124);
            listView10.Name = "listView10";
            listView10.Size = new Size(90, 91);
            listView10.TabIndex = 53;
            listView10.UseCompatibleStateImageBehavior = false;
            listView10.View = View.Details;
            listView10.Scrolled += listView_Scrolled;
            // 
            // listView11
            // 
            listView11.Location = new Point(291, 124);
            listView11.Name = "listView11";
            listView11.Size = new Size(90, 91);
            listView11.TabIndex = 54;
            listView11.UseCompatibleStateImageBehavior = false;
            listView11.View = View.Details;
            listView11.Scrolled += listView_Scrolled;
            // 
            // listView12
            // 
            listView12.Location = new Point(387, 124);
            listView12.Name = "listView12";
            listView12.Size = new Size(90, 91);
            listView12.TabIndex = 55;
            listView12.UseCompatibleStateImageBehavior = false;
            listView12.View = View.Details;
            listView12.Scrolled += listView_Scrolled;
            // 
            // listView13
            // 
            listView13.Location = new Point(483, 124);
            listView13.Name = "listView13";
            listView13.Size = new Size(90, 91);
            listView13.TabIndex = 56;
            listView13.UseCompatibleStateImageBehavior = false;
            listView13.View = View.Details;
            listView13.Scrolled += listView_Scrolled;
            // 
            // listView14
            // 
            listView14.Location = new Point(579, 124);
            listView14.Name = "listView14";
            listView14.Size = new Size(90, 91);
            listView14.TabIndex = 57;
            listView14.UseCompatibleStateImageBehavior = false;
            listView14.View = View.Details;
            listView14.Scrolled += listView_Scrolled;
            // 
            // listView15
            // 
            listView15.Location = new Point(3, 221);
            listView15.Name = "listView15";
            listView15.Size = new Size(90, 91);
            listView15.TabIndex = 58;
            listView15.UseCompatibleStateImageBehavior = false;
            listView15.View = View.Details;
            listView15.Scrolled += listView_Scrolled;
            // 
            // listView16
            // 
            listView16.Location = new Point(99, 221);
            listView16.Name = "listView16";
            listView16.Size = new Size(90, 91);
            listView16.TabIndex = 59;
            listView16.UseCompatibleStateImageBehavior = false;
            listView16.View = View.Details;
            listView16.Scrolled += listView_Scrolled;
            // 
            // listView17
            // 
            listView17.Location = new Point(195, 221);
            listView17.Name = "listView17";
            listView17.Size = new Size(90, 91);
            listView17.TabIndex = 60;
            listView17.UseCompatibleStateImageBehavior = false;
            listView17.View = View.Details;
            listView17.Scrolled += listView_Scrolled;
            // 
            // listView18
            // 
            listView18.Location = new Point(291, 221);
            listView18.Name = "listView18";
            listView18.Size = new Size(90, 91);
            listView18.TabIndex = 61;
            listView18.UseCompatibleStateImageBehavior = false;
            listView18.View = View.Details;
            listView18.Scrolled += listView_Scrolled;
            // 
            // listView19
            // 
            listView19.Location = new Point(387, 221);
            listView19.Name = "listView19";
            listView19.Size = new Size(90, 91);
            listView19.TabIndex = 62;
            listView19.UseCompatibleStateImageBehavior = false;
            listView19.View = View.Details;
            listView19.Scrolled += listView_Scrolled;
            // 
            // listView20
            // 
            listView20.Location = new Point(483, 221);
            listView20.Name = "listView20";
            listView20.Size = new Size(90, 91);
            listView20.TabIndex = 63;
            listView20.UseCompatibleStateImageBehavior = false;
            listView20.View = View.Details;
            listView20.Scrolled += listView_Scrolled;
            // 
            // listView21
            // 
            listView21.Location = new Point(579, 221);
            listView21.Name = "listView21";
            listView21.Size = new Size(90, 91);
            listView21.TabIndex = 64;
            listView21.UseCompatibleStateImageBehavior = false;
            listView21.View = View.Details;
            listView21.Scrolled += listView_Scrolled;
            // 
            // listView22
            // 
            listView22.Location = new Point(3, 318);
            listView22.Name = "listView22";
            listView22.Size = new Size(90, 91);
            listView22.TabIndex = 65;
            listView22.UseCompatibleStateImageBehavior = false;
            listView22.View = View.Details;
            listView22.Scrolled += listView_Scrolled;
            // 
            // listView23
            // 
            listView23.Location = new Point(99, 318);
            listView23.Name = "listView23";
            listView23.Size = new Size(90, 91);
            listView23.TabIndex = 66;
            listView23.UseCompatibleStateImageBehavior = false;
            listView23.View = View.Details;
            listView23.Scrolled += listView_Scrolled;
            // 
            // listView24
            // 
            listView24.Location = new Point(195, 318);
            listView24.Name = "listView24";
            listView24.Size = new Size(90, 91);
            listView24.TabIndex = 67;
            listView24.UseCompatibleStateImageBehavior = false;
            listView24.View = View.Details;
            listView24.Scrolled += listView_Scrolled;
            // 
            // listView25
            // 
            listView25.Location = new Point(291, 318);
            listView25.Name = "listView25";
            listView25.Size = new Size(90, 91);
            listView25.TabIndex = 68;
            listView25.UseCompatibleStateImageBehavior = false;
            listView25.View = View.Details;
            listView25.Scrolled += listView_Scrolled;
            // 
            // listView26
            // 
            listView26.Location = new Point(387, 318);
            listView26.Name = "listView26";
            listView26.Size = new Size(90, 91);
            listView26.TabIndex = 69;
            listView26.UseCompatibleStateImageBehavior = false;
            listView26.View = View.Details;
            listView26.Scrolled += listView_Scrolled;
            // 
            // listView27
            // 
            listView27.Location = new Point(483, 318);
            listView27.Name = "listView27";
            listView27.Size = new Size(90, 91);
            listView27.TabIndex = 70;
            listView27.UseCompatibleStateImageBehavior = false;
            listView27.View = View.Details;
            listView27.Scrolled += listView_Scrolled;
            // 
            // listView28
            // 
            listView28.Location = new Point(579, 318);
            listView28.Name = "listView28";
            listView28.Size = new Size(90, 91);
            listView28.TabIndex = 71;
            listView28.UseCompatibleStateImageBehavior = false;
            listView28.View = View.Details;
            listView28.Scrolled += listView_Scrolled;
            // 
            // listView29
            // 
            listView29.Location = new Point(3, 415);
            listView29.Name = "listView29";
            listView29.Size = new Size(90, 91);
            listView29.TabIndex = 72;
            listView29.UseCompatibleStateImageBehavior = false;
            listView29.View = View.Details;
            listView29.Scrolled += listView_Scrolled;
            // 
            // listView30
            // 
            listView30.Location = new Point(99, 415);
            listView30.Name = "listView30";
            listView30.Size = new Size(90, 91);
            listView30.TabIndex = 73;
            listView30.UseCompatibleStateImageBehavior = false;
            listView30.View = View.Details;
            listView30.Scrolled += listView_Scrolled;
            // 
            // listView31
            // 
            listView31.Location = new Point(195, 415);
            listView31.Name = "listView31";
            listView31.Size = new Size(90, 91);
            listView31.TabIndex = 74;
            listView31.UseCompatibleStateImageBehavior = false;
            listView31.View = View.Details;
            listView31.Scrolled += listView_Scrolled;
            // 
            // listView32
            // 
            listView32.Location = new Point(291, 415);
            listView32.Name = "listView32";
            listView32.Size = new Size(90, 91);
            listView32.TabIndex = 75;
            listView32.UseCompatibleStateImageBehavior = false;
            listView32.View = View.Details;
            listView32.Scrolled += listView_Scrolled;
            // 
            // listView33
            // 
            listView33.Location = new Point(387, 415);
            listView33.Name = "listView33";
            listView33.Size = new Size(90, 91);
            listView33.TabIndex = 76;
            listView33.UseCompatibleStateImageBehavior = false;
            listView33.View = View.Details;
            listView33.Scrolled += listView_Scrolled;
            // 
            // listView34
            // 
            listView34.Location = new Point(483, 415);
            listView34.Name = "listView34";
            listView34.Size = new Size(90, 91);
            listView34.TabIndex = 77;
            listView34.UseCompatibleStateImageBehavior = false;
            listView34.View = View.Details;
            listView34.Scrolled += listView_Scrolled;
            // 
            // listView35
            // 
            listView35.Location = new Point(579, 415);
            listView35.Name = "listView35";
            listView35.Size = new Size(90, 91);
            listView35.TabIndex = 78;
            listView35.UseCompatibleStateImageBehavior = false;
            listView35.View = View.Details;
            listView35.Scrolled += listView_Scrolled;
            // 
            // listView36
            // 
            listView36.Location = new Point(3, 512);
            listView36.Name = "listView36";
            listView36.Size = new Size(90, 91);
            listView36.TabIndex = 85;
            listView36.UseCompatibleStateImageBehavior = false;
            listView36.View = View.Details;
            listView36.Scrolled += listView_Scrolled;
            // 
            // listView37
            // 
            listView37.Location = new Point(99, 512);
            listView37.Name = "listView37";
            listView37.Size = new Size(90, 91);
            listView37.TabIndex = 86;
            listView37.UseCompatibleStateImageBehavior = false;
            listView37.View = View.Details;
            listView37.Scrolled += listView_Scrolled;
            // 
            // listView38
            // 
            listView38.Location = new Point(195, 512);
            listView38.Name = "listView38";
            listView38.Size = new Size(90, 91);
            listView38.TabIndex = 87;
            listView38.UseCompatibleStateImageBehavior = false;
            listView38.View = View.Details;
            listView38.Scrolled += listView_Scrolled;
            // 
            // listView39
            // 
            listView39.Location = new Point(291, 512);
            listView39.Name = "listView39";
            listView39.Size = new Size(90, 91);
            listView39.TabIndex = 89;
            listView39.UseCompatibleStateImageBehavior = false;
            listView39.View = View.Details;
            listView39.Scrolled += listView_Scrolled;
            // 
            // listView40
            // 
            listView40.Location = new Point(387, 512);
            listView40.Name = "listView40";
            listView40.Size = new Size(90, 91);
            listView40.TabIndex = 88;
            listView40.UseCompatibleStateImageBehavior = false;
            listView40.View = View.Details;
            listView40.Scrolled += listView_Scrolled;
            // 
            // listView41
            // 
            listView41.Location = new Point(483, 512);
            listView41.Name = "listView41";
            listView41.Size = new Size(90, 91);
            listView41.TabIndex = 90;
            listView41.UseCompatibleStateImageBehavior = false;
            listView41.View = View.Details;
            listView41.Scrolled += listView_Scrolled;
            // 
            // listView42
            // 
            listView42.Location = new Point(579, 512);
            listView42.Name = "listView42";
            listView42.Size = new Size(90, 91);
            listView42.TabIndex = 91;
            listView42.UseCompatibleStateImageBehavior = false;
            listView42.View = View.Details;
            listView42.Scrolled += listView_Scrolled;
            // 
            // pnlDays
            // 
            pnlDays.BorderStyle = BorderStyle.Fixed3D;
            pnlDays.Controls.Add(listView1);
            pnlDays.Controls.Add(listView2);
            pnlDays.Controls.Add(lblFriday);
            pnlDays.Controls.Add(listView3);
            pnlDays.Controls.Add(lblSaturday);
            pnlDays.Controls.Add(listView4);
            pnlDays.Controls.Add(listView5);
            pnlDays.Controls.Add(lblSunday);
            pnlDays.Controls.Add(listView6);
            pnlDays.Controls.Add(lblThursday);
            pnlDays.Controls.Add(listView7);
            pnlDays.Controls.Add(listView8);
            pnlDays.Controls.Add(lblWednesday);
            pnlDays.Controls.Add(listView9);
            pnlDays.Controls.Add(lblTuesday);
            pnlDays.Controls.Add(listView10);
            pnlDays.Controls.Add(lblMonday);
            pnlDays.Controls.Add(listView11);
            pnlDays.Controls.Add(listView12);
            pnlDays.Controls.Add(listView13);
            pnlDays.Controls.Add(listView14);
            pnlDays.Controls.Add(listView15);
            pnlDays.Controls.Add(listView16);
            pnlDays.Controls.Add(listView17);
            pnlDays.Controls.Add(listView18);
            pnlDays.Controls.Add(listView19);
            pnlDays.Controls.Add(listView20);
            pnlDays.Controls.Add(listView21);
            pnlDays.Controls.Add(listView22);
            pnlDays.Controls.Add(listView23);
            pnlDays.Controls.Add(listView24);
            pnlDays.Controls.Add(listView25);
            pnlDays.Controls.Add(listView26);
            pnlDays.Controls.Add(listView27);
            pnlDays.Controls.Add(listView28);
            pnlDays.Controls.Add(listView29);
            pnlDays.Controls.Add(listView30);
            pnlDays.Controls.Add(listView31);
            pnlDays.Controls.Add(listView32);
            pnlDays.Controls.Add(listView33);
            pnlDays.Controls.Add(listView34);
            pnlDays.Controls.Add(listView35);
            pnlDays.Controls.Add(listView36);
            pnlDays.Controls.Add(listView37);
            pnlDays.Controls.Add(listView38);
            pnlDays.Controls.Add(listView39);
            pnlDays.Controls.Add(listView40);
            pnlDays.Controls.Add(listView41);
            pnlDays.Controls.Add(listView42);
            pnlDays.Location = new Point(12, 56);
            pnlDays.Name = "pnlDays";
            pnlDays.Size = new Size(676, 610);
            pnlDays.TabIndex = 79;
            // 
            // dtpMonth
            // 
            dtpMonth.CustomFormat = " MMMM yyyy ";
            dtpMonth.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.Location = new Point(265, 16);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.ShowUpDown = true;
            dtpMonth.Size = new Size(175, 33);
            dtpMonth.TabIndex = 42;
            dtpMonth.ValueChanged += dtpMonth_ValueChanged;
            // 
            // btnPreviousMonth
            // 
            btnPreviousMonth.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPreviousMonth.Location = new Point(217, 13);
            btnPreviousMonth.Name = "btnPreviousMonth";
            btnPreviousMonth.Size = new Size(42, 38);
            btnPreviousMonth.TabIndex = 43;
            btnPreviousMonth.Text = "◀";
            btnPreviousMonth.UseVisualStyleBackColor = true;
            btnPreviousMonth.Click += btnPreviousMonth_Click;
            // 
            // btnNextMonth
            // 
            btnNextMonth.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNextMonth.Location = new Point(446, 13);
            btnNextMonth.Name = "btnNextMonth";
            btnNextMonth.Size = new Size(42, 38);
            btnNextMonth.TabIndex = 44;
            btnNextMonth.Text = "▶";
            btnNextMonth.UseVisualStyleBackColor = true;
            btnNextMonth.Click += btnNextMonth_Click;
            // 
            // pnlConfig
            // 
            pnlConfig.BorderStyle = BorderStyle.Fixed3D;
            pnlConfig.Controls.Add(dgvConfig);
            pnlConfig.Location = new Point(694, 56);
            pnlConfig.Name = "pnlConfig";
            pnlConfig.Size = new Size(460, 610);
            pnlConfig.TabIndex = 80;
            // 
            // dgvConfig
            // 
            dgvConfig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConfig.Location = new Point(3, 3);
            dgvConfig.Name = "dgvConfig";
            dgvConfig.Size = new Size(450, 597);
            dgvConfig.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(992, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(157, 38);
            btnRefresh.TabIndex = 81;
            btnRefresh.Text = "Refresh calendar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // chkShowConfig
            // 
            chkShowConfig.CheckAlign = ContentAlignment.MiddleRight;
            chkShowConfig.Location = new Point(584, 16);
            chkShowConfig.Name = "chkShowConfig";
            chkShowConfig.Size = new Size(104, 37);
            chkShowConfig.TabIndex = 82;
            chkShowConfig.Text = "Show configurations";
            chkShowConfig.UseVisualStyleBackColor = true;
            chkShowConfig.CheckedChanged += chkShowConfig_CheckedChanged;
            // 
            // FormCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 670);
            Controls.Add(chkShowConfig);
            Controls.Add(btnRefresh);
            Controls.Add(pnlConfig);
            Controls.Add(pnlDays);
            Controls.Add(btnNextMonth);
            Controls.Add(btnPreviousMonth);
            Controls.Add(dtpMonth);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormCalendar";
            Text = "Calendar";
            Load += FormCalendar_Load;
            pnlDays.ResumeLayout(false);
            pnlDays.PerformLayout();
            pnlConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConfig).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMonday;
        private Label lblTuesday;
        private Label lblWednesday;
        private Label lblThursday;
        private Label lblFriday;
        private Label lblSaturday;
        private Label lblSunday;
        private ScrollingListView listView1;
        private ScrollingListView listView2;
        private ScrollingListView listView3;
        private ScrollingListView listView4;
        private ScrollingListView listView5;
        private ScrollingListView listView6;
        private ScrollingListView listView7;
        private ScrollingListView listView8;
        private ScrollingListView listView9;
        private ScrollingListView listView10;
        private ScrollingListView listView11;
        private ScrollingListView listView12;
        private ScrollingListView listView13;
        private ScrollingListView listView14;
        private ScrollingListView listView15;
        private ScrollingListView listView16;
        private ScrollingListView listView17;
        private ScrollingListView listView18;
        private ScrollingListView listView19;
        private ScrollingListView listView20;
        private ScrollingListView listView21;
        private ScrollingListView listView22;
        private ScrollingListView listView23;
        private ScrollingListView listView24;
        private ScrollingListView listView25;
        private ScrollingListView listView26;
        private ScrollingListView listView27;
        private ScrollingListView listView28;
        private ScrollingListView listView29;
        private ScrollingListView listView30;
        private ScrollingListView listView31;
        private ScrollingListView listView32;
        private ScrollingListView listView33;
        private ScrollingListView listView34;
        private ScrollingListView listView35;
        private ScrollingListView listView36;
        private ScrollingListView listView37;
        private ScrollingListView listView38;
        private ScrollingListView listView39;
        private ScrollingListView listView40;
        private ScrollingListView listView41;
        private ScrollingListView listView42;
        private Panel pnlDays;
        private DateTimePicker dtpMonth;
        private Button btnPreviousMonth;
        private Button btnNextMonth;
        private Panel pnlConfig;
        private DataGridView dgvConfig;
        private Button btnRefresh;
        private CheckBox chkShowConfig;
    }
}
