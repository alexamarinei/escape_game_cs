using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoEscape
{
    public partial class Form1 : Form
    {
        int[,] order_list = {
            { 1,2,3,4,5,6 },
            { 2,1,3,4,5,6 },
            { 5,6,4,3,1,2 },
            { 6,1,3,4,5,2 },
            { 5,1,3,4,2,6 },
            { 1,2,4,3,5,6 },
            { 4,5,3,2,1,6 },
            { 2,3,4,5,6,1 },
            { 2,5,6,4,3,1 },
            { 3,4,5,6,1,2 }
        };

        int level = 1;
        int time = 20;
        int actual_number = 1;
        int dificulty = 1;
        int x = 106;
        bool right = true;
        int time_anim = 20;

        // BUILDER DATA
        Panel E_ZONE = new Panel();
        Panel S_ZONE = new Panel();
        Panel C_ZONE = new Panel();
        Panel A_ZONE = new Panel();
        Panel P_ZONE = new Panel();
        Panel E2_ZONE = new Panel();

        // DECORATOR DATA
        BackgroundDecorator d1 = new BackgroundDecorator();

        // OBSERVER DATA
        ConcreteObserver time_left    = new ConcreteObserver();
        ConcreteObserver level_passed = new ConcreteObserver();

        public Form1()
        {
            InitializeComponent();
            this.ZONE_1.Visible = false;
            this.ZONE_2.Visible = false;
            this.ZONE_3.Visible = false;
            this.ZONE_4.Visible = false;
            this.ZONE_5.Visible = false;
            this.ZONE_6.Visible = false;
            this.INGAME_SCORE.Visible = false;
            this.time_zone.Visible = false;
            this.DIF1.BackColor = Color.Lime;
            this.END_GAME.Visible = false;


        //------------------- BUILDER


            // CONSTRUIRE
            Director director = new Director();

            Builder E = new EscapeImageBuild();
            director.Construct(E, 60, 60, 35, 25);
            Builder S = new EscapeImageBuild();
            director.Construct(S, 60, 60, 95, 25);
            Builder C = new EscapeImageBuild();
            director.Construct(C, 60, 60, 155, 25);
            Builder A = new EscapeImageBuild();
            director.Construct(A, 60, 60, 215, 25);
            Builder P = new EscapeImageBuild();
            director.Construct(P, 60, 60, 275, 25);
            Builder E2 = new EscapeImageBuild();
            director.Construct(E2, 60, 60, 335, 25);

            // PRELUARE
            this.E_ZONE = E.Show();
            this.S_ZONE = S.Show();
            this.C_ZONE = C.Show();
            this.A_ZONE = A.Show();
            this.P_ZONE = P.Show();
            this.E2_ZONE = E2.Show();

            // AFISARE
            this.Controls.Add(E_ZONE);
            this.Controls.Add(S_ZONE);
            this.Controls.Add(C_ZONE);
            this.Controls.Add(A_ZONE);
            this.Controls.Add(P_ZONE);
            this.Controls.Add(E2_ZONE);
            ////////////////////////////////////
            escape_zone_reset();

            //------------------- DECORATOR
            d1.Operation(this);

            //---------------------- Factory Method

            Creator[] Mode = new Creator[3];

            Mode[0] = new EasyModeCreate();
            Mode[1] = new NormalModeCreate();
            Mode[2] = new HardModeCreate();

            // Iterate over creators and create products

            Product DIF1data = Mode[0].FactoryMethod();
            DIF1.Text = DIF1data.GetType().Name;
            Product DIF2data = Mode[1].FactoryMethod();
            DIF2.Text = DIF2data.GetType().Name;
            Product DIF3data = Mode[2].FactoryMethod();
            DIF3.Text = DIF3data.GetType().Name;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BUTTON_START_Click(object sender, EventArgs e)
        {

            this.INGAME_SCORE.Visible = true;
            this.BUTTON_START.Text = "RESTART";
            this.GAME_START.Enabled = true;
            this.time_zone.Visible = true;

            this.DIF1.Visible = false;
            this.DIF2.Visible = false;
            this.DIF3.Visible = false;


            GAME_START_INTERFACE(level);
            this.Verify.Enabled = true;
            this.BUTTON_START.Visible = false;
            this.END_GAME.Visible = false;
            this.ESCAPE.Visible = true;

        }

        private void GAME_START_Tick(object sender, EventArgs e)
        {
            if (time <= 0)
            {
                lose();
            }
            if (actual_number > 6)
            {
                win();
            }
            time--;

        }
        private void Verify_Tick(object sender, EventArgs e)
        { 
            //------------------------------OBSERVER-----------------------
            time_left.Update(time_zone, "Time", time + "");
            level_passed.Update(INGAME_SCORE, "LEVEL", level + "");
        }

        private void GAME_START_INTERFACE(int lv)
        {
            this.ESCAPE.Visible = true;
            escape_zone_reset();

            this.ZONE_1.Text = order_list[lv - 1, 0] + "";
            this.ZONE_2.Text = order_list[lv - 1, 1] + "";
            this.ZONE_3.Text = order_list[lv - 1, 2] + "";
            this.ZONE_4.Text = order_list[lv - 1, 3] + "";
            this.ZONE_5.Text = order_list[lv - 1, 4] + "";
            this.ZONE_6.Text = order_list[lv - 1, 5] + "";

            this.ZONE_1.BackColor = Color.Black;
            this.ZONE_2.BackColor = Color.Black;
            this.ZONE_3.BackColor = Color.Black;
            this.ZONE_4.BackColor = Color.Black;
            this.ZONE_5.BackColor = Color.Black;
            this.ZONE_6.BackColor = Color.Black;

            this.ZONE_1.Visible = true;
            this.ZONE_2.Visible = true;
            this.ZONE_3.Visible = true;
            this.ZONE_4.Visible = true;
            this.ZONE_5.Visible = true;
            this.ZONE_6.Visible = true;

            this.GAME_START.Enabled = true;
            if (level > 5)
            {
                this.GAME_START.Enabled = false;
                this.ESCAPE.Visible = false;
                this.INGAME_SCORE.Visible = false;
                time = 20;
                this.ZONE_1.Visible = false;
                this.ZONE_2.Visible = false;
                this.ZONE_3.Visible = false;
                this.ZONE_4.Visible = false;
                this.ZONE_5.Visible = false;
                this.ZONE_6.Visible = false;
                this.BUTTON_START.Text = "START";
                this.BUTTON_START.Visible = true;
                this.END_GAME.Visible = true;
                this.time_zone.Visible = false;
                level = 1;

            }
        }

        private void lose()
        {
            this.GAME_START.Enabled = false;
            this.Verify.Enabled = false;

            this.BUTTON_START.Visible = true;

            this.time_zone.Text = "LOSE!";
            level = 1;
            time = 20;
            actual_number = 1;


            this.DIF1.Visible = true;
            this.DIF2.Visible = true;
            this.DIF3.Visible = true;

            this.ZONE_1.Visible = false;
            this.ZONE_2.Visible = false;
            this.ZONE_3.Visible = false;
            this.ZONE_4.Visible = false;
            this.ZONE_5.Visible = false;
            this.ZONE_6.Visible = false;

        }

        private void win()
        {
            d1.Operation(this);
            time = 20 - level * dificulty;
            level++;
            actual_number = 1;
            GAME_START_INTERFACE(level);
            this.timer_anim.Enabled = true;
        }

        private void ZONE_1_Click(object sender, EventArgs e)
        {
            if (actual_number == int.Parse(this.ZONE_1.Text))
            {
                actualizare();
                this.ZONE_1.BackColor = Color.Lime;
                actual_number++;
            }
            else
            {
                lose();
                this.ZONE_1.BackColor = Color.Red;
            }
        }

        private void ZONE_2_Click(object sender, EventArgs e)
        {
            if (actual_number == int.Parse(this.ZONE_2.Text))
            {
                actualizare();
                this.ZONE_2.BackColor = Color.Lime;
                actual_number++;
            }
            else
            {
                lose();
                this.ZONE_2.BackColor = Color.Red;
            }
        }

        private void ZONE_3_Click(object sender, EventArgs e)
        {
            if (actual_number == int.Parse(this.ZONE_3.Text))
            {
                actualizare();
                this.ZONE_3.BackColor = Color.Lime;
                actual_number++;
            }
            else
            {
                lose();
                this.ZONE_3.BackColor = Color.Red;
            }
        }

        private void ZONE_4_Click(object sender, EventArgs e)
        {
            if (actual_number == int.Parse(this.ZONE_4.Text))
            {
                actualizare();
                this.ZONE_4.BackColor = Color.Lime;
                actual_number++;
            }
            else
            {
                lose();
                this.ZONE_4.BackColor = Color.Red;
            }
        }

        private void ZONE_5_Click(object sender, EventArgs e)
        {
            if (actual_number == int.Parse(this.ZONE_5.Text))
            {
                actualizare();
                this.ZONE_5.BackColor = Color.Lime;
                actual_number++;
            }
            else
            {
                lose();
                this.ZONE_5.BackColor = Color.Red;
            }
        }

        private void ZONE_6_Click(object sender, EventArgs e)
        {
            if (actual_number == int.Parse(this.ZONE_6.Text))
            {
                actualizare();
                this.ZONE_6.BackColor = Color.Lime;
                actual_number++;
            }
            else
            {
                lose();
                this.ZONE_6.BackColor = Color.Red;
            }
        }

        private void actualizare()
        {
            if (actual_number == 1) { this.E_ZONE.BackgroundImage = NoEscape.Properties.Resources.E_ACTIVE; }
            if (actual_number == 2) { this.S_ZONE.BackgroundImage = NoEscape.Properties.Resources.S_ACTIVE; }
            if (actual_number == 3) { this.C_ZONE.BackgroundImage = NoEscape.Properties.Resources.C_ACTIVE; }
            if (actual_number == 4) { this.A_ZONE.BackgroundImage = NoEscape.Properties.Resources.A_ACTIVE; }
            if (actual_number == 5) { this.P_ZONE.BackgroundImage = NoEscape.Properties.Resources.P_ACTIVE; }
            if (actual_number == 6) { this.E2_ZONE.BackgroundImage = NoEscape.Properties.Resources.E_ACTIVE; }
        }
        private void escape_zone_reset()
        {
            this.E_ZONE.BackgroundImage = NoEscape.Properties.Resources.E_NORMAL;
            this.S_ZONE.BackgroundImage = NoEscape.Properties.Resources.S_NORMAL;
            this.C_ZONE.BackgroundImage = NoEscape.Properties.Resources.C_NORMAL;
            this.A_ZONE.BackgroundImage = NoEscape.Properties.Resources.A_NORMAL;
            this.P_ZONE.BackgroundImage = NoEscape.Properties.Resources.P_NORMAL;
            this.E2_ZONE.BackgroundImage = NoEscape.Properties.Resources.E_NORMAL;
        }

        private void DIF1_Click(object sender, EventArgs e)
        {
            dificulty = 1;
            this.DIF1.BackColor = Color.Lime;
            this.DIF2.BackColor = Color.Black;
            this.DIF3.BackColor = Color.Black;
        }

        private void DIF2_Click(object sender, EventArgs e)
        {
            dificulty = 2;
            this.DIF1.BackColor = Color.Black;
            this.DIF2.BackColor = Color.Lime;
            this.DIF3.BackColor = Color.Black;
        }

        private void DIF3_Click(object sender, EventArgs e)
        {
            dificulty = 3;
            this.DIF1.BackColor = Color.Black;
            this.DIF2.BackColor = Color.Black;
            this.DIF3.BackColor = Color.Lime;
        }

        private void anim()
        {

        }

        private void timer_anim_Tick(object sender, EventArgs e)
        {
            this.ESCAPE.Location = new Point(x, this.ESCAPE.Location.Y);
            if (right == true)
            {
                x += 3;
                if (x > 116)
                {
                    right = false;
                }
            }
            else
            {
                x -= 3;
                if (x < 96)
                {
                    right = true;
                }
            }
            time_anim--;
            if (time_anim < 0)
            {
                this.ESCAPE.Location = new Point(100, this.ESCAPE.Location.Y);
                this.timer_anim.Enabled = false;
                right = true;
                time_anim = 20;
            }
        }
    }



    //---------------------------- BUILDER ------------------------------------------
    class Director

    {

        public void Construct(Builder builder, int width, int height, int x, int y)
        {
            builder.StructurePanel(width, height, x, y);
        }
    }

    abstract class Builder

    {
        public abstract void StructurePanel(int width, int height, int x, int y);
        public abstract Panel Show();
    }

    class EscapeImageBuild : Builder
    {
        Panel panel = new Panel();

        public override void StructurePanel(int width, int height, int x, int y)
        {
            panel.Size = new System.Drawing.Size(width, height);
            panel.Location = new Point(x, y);
            panel.BackgroundImageLayout = ImageLayout.Zoom;
        }
        public override Panel Show()
        {
            return panel;

        }
    }

    //-------------------------------------------------------------------------------



    //---------------------------- DECORATOR ----------------------------------------

 
    abstract class Decorator 

    {

        public abstract void Operation(Form form);
    }
    class BackgroundDecorator : Decorator

    {
        public override void Operation(Form form)
        {
            Random rand = new Random();
            switch (rand.Next(1, 5))
            {
                case 1: form.BackColor = Color.Red; break;
                case 2: form.BackColor = Color.Green; break;
                case 3: form.BackColor = Color.Blue; break;
                case 4: form.BackColor = Color.Purple; break;
            }
             
        }
    }
    //-------------------------------------------------------------------------------



    //---------------------------- OBSERVER ----------------------------------------


    abstract class Observer

    {
        public abstract void Update(Label componnent, string pre, string data);
    }

    class ConcreteObserver : Observer

    {


        public override void Update(Label componnent,string pre,string data)
        {
            componnent.Text = pre + ": " + data;

        }


    }


    //------------------------------------------------------------------------------


    //---------------------------- Factory method ------------------------------------------

    abstract class Product { }
    class EASY : Product { }
    class NORMAL: Product { }
    class HARD : Product { }

    abstract class Creator 
    {
        public abstract Product FactoryMethod();
    }
    class EasyModeCreate : Creator

    {
        public override Product FactoryMethod()
        {
            return new EASY();
        }
    }
    class NormalModeCreate : Creator

    {
        public override Product FactoryMethod()
        {
            return new NORMAL();
        }
    }
    class HardModeCreate : Creator

    {
        public override Product FactoryMethod()
        {
            return new HARD();
        }
    }


    //------------------------------------------------------------------------------

}
