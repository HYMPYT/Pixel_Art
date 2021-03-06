﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelArt
{
    public partial class Form1 : Form
    {
        // Змінні для зберігання статусу миші
        public bool IsPressedLeft { get; set; } 
        public bool IsPressedRight { get; set; } 

        public Point FirstCord { get; set; } // Перша координата на полі при кліку миші по полю
        public Color LeftColor { get; set; } // Колір лівої кнопки миші
        public Color RightColor { get; set; } // Колір правої кнопки миші

        private Color FoneColor; // Колір який ми зафарбовуємо заливкою 
        private bool CallFunction = true;
        private static int count = 1;
        private item currItem;

        public Form1()
        {
            InitializeComponent();
            LeftColor = LeftColorBtn.BackColor = Color.Black;
            RightColor = RightColorBtn.BackColor = Color.White;
            currItem = item.Pencil;
            PencilBtn.Enabled = false;
            PencilBtn.BackColor = Color.LightCyan;
        }

        enum item
        {
            Pencil, Pipette, ColorFill, Erase
        }

        private void Fill(Point p) // Функція заливки потрібно переробити викидає тому що рекурсія
        {
            int x, y;
            if (radioBtn16.Checked)
            {
                foreach (var item in Field.Controls)
                {
                    x = ((PictureBox)item).Location.X;
                    y = ((PictureBox)item).Location.Y;
                    if (p.X == x && p.Y == y)
                    {
                        ((PictureBox)item).BackColor = RightColor;
                        continue;
                    }
                    if (p.X == x && p.Y - 44 == y && ((PictureBox)item).BackColor == FoneColor)
                    {
                        Fill(new Point(x, y));
                    }
                    if (p.X + 44 == x && p.Y == y && ((PictureBox)item).BackColor == FoneColor)
                    {
                        Fill(new Point(x, y));
                    }
                    if (p.X == x && p.Y + 44 == y && ((PictureBox)item).BackColor == FoneColor)
                    {
                        Fill(new Point(x, y));
                    }
                    if (p.X - 44 == x && p.Y == y && ((PictureBox)item).BackColor == FoneColor)
                    {
                        Fill(new Point(x, y));
                    }
                }
            }
            if (radioBtn32.Checked)
            {
                foreach (var item in Field.Controls)
                {
                    x = ((PictureBox)item).Location.X;
                    y = ((PictureBox)item).Location.Y;
                    if (p.X == x && p.Y == y)
                    {
                        ((PictureBox)item).BackColor = RightColor;
                        continue;
                    }
                    if (p.X == x && p.Y - 22 == y && ((PictureBox)item).BackColor == FoneColor)
                    {
                        Fill(new Point(x, y));
                    }
                    if (p.X + 22 == x && p.Y == y && ((PictureBox)item).BackColor == FoneColor)
                    {
                        Fill(new Point(x, y));
                    }
                    if (p.X == x && p.Y + 22 == y && ((PictureBox)item).BackColor == FoneColor)
                    {
                        Fill(new Point(x, y));
                    }
                    if (p.X - 22 == x && p.Y == y && ((PictureBox)item).BackColor == FoneColor)
                    {
                        Fill(new Point(x, y));
                    }
                }
            }
        }

        private void PixelMouseClick(object sender, MouseEventArgs e) // Якщо була нажата кнопка миші то ...
        {
            switch (currItem)
            {
                case item.Pencil:
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            sender.GetType().GetProperty("BackColor").SetValue(sender, LeftColor);
                        }
                        if (e.Button == MouseButtons.Right)
                        {
                            sender.GetType().GetProperty("BackColor").SetValue(sender, RightColor);
                        }
                        break;
                    }

                case item.Pipette:
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            LeftColor = LeftColorBtn.BackColor = (Color)sender.GetType().GetProperty("BackColor").GetValue(sender);
                        }
                        if (e.Button == MouseButtons.Right)
                        {
                            RightColor = RightColorBtn.BackColor = (Color)sender.GetType().GetProperty("BackColor").GetValue(sender);
                        }
                        break;
                    }

                case item.ColorFill:
                    {
                        FirstCord = (Point)sender.GetType().GetProperty("Location").GetValue(sender);
                        FoneColor = (Color)sender.GetType().GetProperty("BackColor").GetValue(sender);
                        if (FoneColor == RightColor)
                        {
                            MessageBox.Show("Цвет заливки должен отличаться от цвета который вы хотите закрасить.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            Fill(FirstCord);
                        }
                        break;
                    }

                case item.Erase:
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            sender.GetType().GetProperty("BackColor").SetValue(sender, RightColor);
                        }
                        break;
                    }
            }
        }

        private void PixelMouseDown(object sender, MouseEventArgs e) // Якщо кнопка миші зажата то ...
        {
            if (e.Button == MouseButtons.Left)
            {
                IsPressedLeft = true;

            }
            else if (e.Button == MouseButtons.Right)
            {
                IsPressedRight = true;
            }
        }

        private void PixelMouseMove(object sender, MouseEventArgs e) // Якщо мишка рухається по формі то ...
        {
            int x, y, count = 0;
            FirstCord = (Point)sender.GetType().GetProperty("Location").GetValue(sender);
            switch (currItem)
            {
                case item.Pencil:
                    {
                        if (radioBtn16.Checked)
                        {
                            if (IsPressedLeft == true)
                            {
                                foreach (var item in Field.Controls)
                                {
                                    if (item is PictureBox)
                                    {
                                        if (count == 256)
                                            break;
                                        x = ((PictureBox)item).Location.X;
                                        y = ((PictureBox)item).Location.Y;
                                        if (e.X + FirstCord.X >= x && e.X + FirstCord.X <= x + 40 && e.Y + FirstCord.Y >= y && e.Y + FirstCord.Y <= y + 40)
                                        {
                                            ((PictureBox)item).BackColor = LeftColor;
                                            break;
                                        }
                                        count++;
                                    }
                                }
                            }
                            else if (IsPressedRight == true)
                            {
                                foreach (var item in Field.Controls)
                                {
                                    if (item is PictureBox)
                                    {
                                        if (count == 256)
                                            break;
                                        x = ((PictureBox)item).Location.X;
                                        y = ((PictureBox)item).Location.Y;
                                        if (e.X + FirstCord.X >= x && e.X + FirstCord.X <= x + 40 && e.Y + FirstCord.Y >= y && e.Y + FirstCord.Y <= y + 40)
                                        {
                                            ((PictureBox)item).BackColor = RightColor;
                                            break;
                                        }
                                        count++;
                                    }
                                }
                            }
                        }
                        else if (radioBtn32.Checked)
                        {
                            if (IsPressedLeft == true)
                            {
                                foreach (var item in Field.Controls)
                                {
                                    if (item is PictureBox)
                                    {
                                        if (count == 1024)
                                            break;
                                        x = ((PictureBox)item).Location.X;
                                        y = ((PictureBox)item).Location.Y;
                                        if (e.X + FirstCord.X >= x && e.X + FirstCord.X <= x + 20 && e.Y + FirstCord.Y >= y && e.Y + FirstCord.Y <= y + 20)
                                        {
                                            ((PictureBox)item).BackColor = LeftColor;
                                            break;
                                        }
                                        count++;
                                    }
                                }
                            }
                            else if (IsPressedRight == true)
                            {
                                foreach (var item in Field.Controls)
                                {
                                    if (item is PictureBox)
                                    {
                                        if (count == 1024)
                                            break;
                                        x = ((PictureBox)item).Location.X;
                                        y = ((PictureBox)item).Location.Y;
                                        if (e.X + FirstCord.X >= x && e.X + FirstCord.X <= x + 20 && e.Y + FirstCord.Y >= y && e.Y + FirstCord.Y <= y + 20)
                                        {
                                            ((PictureBox)item).BackColor = RightColor;
                                            break;
                                        }
                                        count++;
                                    }
                                }
                            }
                        }
                        break;
                    }
                case item.Erase:
                    {
                        if (radioBtn16.Checked)
                        {
                            if (IsPressedLeft == true)
                            {
                                foreach (var item in Field.Controls)
                                {
                                    if (item is PictureBox)
                                    {
                                        if (count == 256)
                                            break;
                                        x = ((PictureBox)item).Location.X;
                                        y = ((PictureBox)item).Location.Y;
                                        if (e.X + FirstCord.X >= x && e.X + FirstCord.X <= x + 40 && e.Y + FirstCord.Y >= y && e.Y + FirstCord.Y <= y + 40)
                                        {
                                            ((PictureBox)item).BackColor = RightColor;
                                            break;
                                        }
                                        count++;
                                    }
                                }
                            }
                        }
                        else if (radioBtn32.Checked)
                        {
                            if (IsPressedLeft == true)
                            {
                                foreach (var item in Field.Controls)
                                {
                                    if (item is PictureBox)
                                    {
                                        if (count == 1024)
                                            break;
                                        x = ((PictureBox)item).Location.X;
                                        y = ((PictureBox)item).Location.Y;
                                        if (e.X + FirstCord.X >= x && e.X + FirstCord.X <= x + 20 && e.Y + FirstCord.Y >= y && e.Y + FirstCord.Y <= y + 20)
                                        {
                                            ((PictureBox)item).BackColor = RightColor;
                                            break;
                                        }
                                        count++;
                                    }
                                }
                            }
                        }
                        break;
                    }
            }

        }

        private void PixelMouseUp(object sender, MouseEventArgs e) // Якщо кнопка миші віджата то ...
        {

            IsPressedLeft = IsPressedRight = false;
        }

        private void SetPixel() // Функція для заповнення поля пікселями по яких згодом будуть малювати
        {
            if (radioBtn16.Checked)
            {
                for (int i = 0; i < 16; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Size = new Size(40, 40);
                        pic.Location = new Point(4 + 44 * j, 4 + 44 * i);
                        pic.BackColor = Color.White;
                        pic.MouseClick += PixelMouseClick;
                        pic.MouseDown += PixelMouseDown;
                        pic.MouseMove += PixelMouseMove;
                        pic.MouseUp += PixelMouseUp;
                        Field.Controls.Add(pic);
                    }
                }
            }
            if (radioBtn32.Checked)
            {
                for (int i = 0; i < 32; i++)
                {
                    for (int j = 0; j < 32; j++)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Size = new Size(20, 20);
                        pic.Location = new Point(2 + 22 * j, 2 + 22 * i);
                        pic.BackColor = Color.White;
                        pic.MouseClick += PixelMouseClick;
                        pic.MouseDown += PixelMouseDown;
                        pic.MouseMove += PixelMouseMove;
                        pic.MouseUp += PixelMouseUp;
                        Field.Controls.Add(pic);
                    }
                }
            }
        }

        private void LoadMap() // Функція для загрузки поля
        {
            SetPixel();
            if (radioBtn16.Checked)
            {
                for (int i = 0; i <= 16; i++)
                {
                    for (int j = 0; j <= 16; j++)
                    {
                        PictureBox pic = new PictureBox();
                        pic.BackColor = Color.Black;
                        pic.Location = new Point(0, 44 * i);
                        pic.Size = new Size(708, 4);
                        Field.Controls.Add(pic);
                    }
                    for (int j = 0; j <= 16; j++)
                    {
                        PictureBox pic = new PictureBox();
                        pic.BackColor = Color.Black;
                        pic.Location = new Point(44 * i, 0);
                        pic.Size = new Size(4, 708);
                        Field.Controls.Add(pic);
                    }
                }
            }
            if (radioBtn32.Checked)
            {
                for (int i = 0; i <= 32; i++)
                {
                    for (int j = 0; j <= 32; j++)
                    {
                        PictureBox pic = new PictureBox();
                        pic.BackColor = Color.Black;
                        pic.Location = new Point(0, 22 * i);
                        pic.Size = new Size(706, 2);
                        Field.Controls.Add(pic);
                    }
                    for (int j = 0; j <= 32; j++)
                    {
                        PictureBox pic = new PictureBox();
                        pic.BackColor = Color.Black;
                        pic.Location = new Point(22 * i, 0);
                        pic.Size = new Size(2, 706);
                        Field.Controls.Add(pic);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMap();
        }

        private bool CheckEmptyArt() // Функція для перевірки чи пусте зараз поле
        {
            int amount = 0;
            if (radioBtn16.Checked)
            {
                foreach (var item in Field.Controls)
                {
                    if (amount == 1024)
                        break;
                    if (((PictureBox)item).BackColor != Color.White)
                        return false;
                    amount++;
                }
                return true;
            }
            else
            {
                foreach (var item in Field.Controls)
                {
                    if (amount == 256)
                        break;
                    if (((PictureBox)item).BackColor != Color.White)
                        return false;
                    amount++;
                }
                return true;
            }
        }

        private void radioBtn32_CheckedChanged(object sender, EventArgs e) // Якщо розмір поля було змінено то ...
        {
            if (radioBtn16.Checked)
            {
                if (!CheckEmptyArt())
                {
                    QuestionForm qf = new QuestionForm();
                    if (qf.ShowDialog() == DialogResult.OK)
                    {
                        CallFunction = false;
                        сохранитьToolStripMenuItem_Click(sender, e);
                        CallFunction = true;
                        Field.Controls.Clear();
                        LoadMap();
                    }
                    else if (qf.DialogResult == DialogResult.Ignore)
                    {
                        Field.Controls.Clear();
                        LoadMap();
                    }
                }
                else
                {
                    Field.Controls.Clear();
                    LoadMap();
                }
            }
            if (radioBtn32.Checked)
            {
                if (!CheckEmptyArt())
                {
                    QuestionForm qf = new QuestionForm();
                    if (qf.ShowDialog() == DialogResult.OK)
                    {
                        CallFunction = false;
                        сохранитьToolStripMenuItem_Click(sender, e);
                        CallFunction = true;
                        Field.Controls.Clear();
                        LoadMap();
                    }
                    else if (qf.DialogResult == DialogResult.Ignore)
                    {
                        Field.Controls.Clear();
                        LoadMap();
                    }
                }
                else
                {
                    Field.Controls.Clear();
                    LoadMap();
                }
            }
        }

        private void PaletteMouseClick(object sender, MouseEventArgs e) // Функція для встановлення кольорів
        {
            if (e.Button == MouseButtons.Left)
            {
                LeftColor = (Color)sender.GetType().GetProperty("BackColor").GetValue(sender);
                LeftColorBtn.BackColor = LeftColor;
            }
            if (e.Button == MouseButtons.Right)
            {
                RightColor = (Color)sender.GetType().GetProperty("BackColor").GetValue(sender);
                RightColorBtn.BackColor = RightColor;
            }
        }

        private void PencilBtn_Click(object sender, EventArgs e) // Якщо вибраний олівець то ...
        {
            PencilBtn.Enabled = false;
            PipetteBtn.Enabled = true;
            ColorFillBtn.Enabled = true;
            EraseBtn.Enabled = true;
            PencilBtn.BackColor = Color.LightCyan;
            PipetteBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            ColorFillBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            EraseBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            currItem = item.Pencil;
        }

        private void PipetteBtn_Click(object sender, EventArgs e) // Якщо вибрана піпетка то ...
        {
            PencilBtn.Enabled = true;
            PipetteBtn.Enabled = false;
            ColorFillBtn.Enabled = true;
            EraseBtn.Enabled = true;
            PencilBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            PipetteBtn.BackColor = Color.LightCyan;
            ColorFillBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            EraseBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            currItem = item.Pipette;
        }

        private void ColorFillBtn_Click(object sender, EventArgs e) // Якщо вибрана заливка то ...
        {
            PencilBtn.Enabled = true;
            PipetteBtn.Enabled = true;
            ColorFillBtn.Enabled = false;
            EraseBtn.Enabled = true;
            PencilBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            PipetteBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            ColorFillBtn.BackColor = Color.LightCyan;
            EraseBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            currItem = item.ColorFill;
        }

        private void EraseBtn_Click(object sender, EventArgs e) // Якщо вибрана стирачка то ...
        {
            PencilBtn.Enabled = true;
            PipetteBtn.Enabled = true;
            ColorFillBtn.Enabled = true;
            EraseBtn.Enabled = false;
            PencilBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            PipetteBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            ColorFillBtn.BackColor = Color.FromKnownColor(KnownColor.Control);
            EraseBtn.BackColor = Color.LightCyan;
            currItem = item.Erase;
        }

        private void ColorMixerBtn_Click(object sender, EventArgs e) // Фукція для виклику готової палітри щоб згодом вибраний колір звідти добавити до своєї палітри
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < 28; i++)
                {
                    if (cd.Color == groupBox1.Controls[$"button{i}"].BackColor)
                    {
                        MessageBox.Show("Выбранный вами цвет уже есть в палитре", "Информационное окно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (button19.BackColor == Color.White)
                {
                    button19.BackColor = cd.Color;
                }
                else
                {
                    if (count == 9)
                    {
                        for (int i = 19; i < 27; i++)
                        {
                            groupBox1.Controls[$"button{i}"].BackColor = groupBox1.Controls[$"button{i + 1}"].BackColor;
                        }
                        button27.BackColor = cd.Color;
                    }
                    else
                    {
                        for (int i = 20; i < 28; i++)
                        {
                            if ((groupBox1.Controls[$"button{i}"] as Button).BackColor == Color.White)
                            {
                                groupBox1.Controls[$"button{i}"].BackColor = cd.Color;
                                count++;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ClearFieldBtn_Click(object sender, EventArgs e) // Функція для очищення поля
        {
            int amount = 0;
            if (radioBtn16.Checked)
            {
                foreach (var item in Field.Controls)
                {
                    if (amount == 256)
                        break;
                    ((PictureBox)item).BackColor = Color.White;
                    amount++;
                }
            }
            if (radioBtn32.Checked)
            {
                foreach (var item in Field.Controls)
                {
                    if (amount == 1024)
                        break;
                    ((PictureBox)item).BackColor = Color.White;
                    amount++;
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG|*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|BMP|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int amount = 0, column = 0, x = 0, y = 0;
                SolidBrush myBrush = new SolidBrush(Color.White);
                PictureBox pic = new PictureBox();
                if (CallFunction)
                {
                    if (radioBtn16.Checked)
                    {
                        pic.Size = new Size(80, 80);
                        var bitmap = new Bitmap(pic.Width, pic.Height);
                        pic.Image = bitmap;
                        Graphics g = Graphics.FromImage(bitmap);
                        foreach (var item in Field.Controls)
                        {
                            if (amount == 256)
                                break;
                            if (column == 16)
                            {
                                column = 0;
                                y += 5;
                                x = 0;
                            }
                            myBrush.Color = ((PictureBox)item).BackColor;
                            g.FillRectangle(myBrush, new Rectangle(x, y, 5, 5));
                            pic.Invalidate();
                            x += 5;
                            column++;
                            amount++;
                        }
                        myBrush.Dispose();
                        g.Dispose();
                        pic.Image.Save(sfd.FileName, ImageFormat.Png);
                    }
                    if (radioBtn32.Checked)
                    {
                        pic.Size = new Size(160, 160);
                        var bitmap = new Bitmap(pic.Width, pic.Height);
                        pic.Image = bitmap;
                        Graphics g = Graphics.FromImage(bitmap);
                        foreach (var item in Field.Controls)
                        {
                            if (amount == 1024)
                                break;
                            if (column == 32)
                            {
                                column = 0;
                                y += 5;
                                x = 0;
                            }
                            myBrush.Color = ((PictureBox)item).BackColor;
                            g.FillRectangle(myBrush, new Rectangle(x, y, 5, 5));
                            pic.Invalidate();
                            x += 5;
                            column++;
                            amount++;
                        }
                        myBrush.Dispose();
                        g.Dispose();
                        pic.Image.Save(sfd.FileName);
                    }
                }
                else
                {
                    if (radioBtn32.Checked)
                    {
                        pic.Size = new Size(80, 80);
                        var bitmap = new Bitmap(pic.Width, pic.Height);
                        pic.Image = bitmap;
                        Graphics g = Graphics.FromImage(bitmap);
                        foreach (var item in Field.Controls)
                        {
                            if (amount == 256)
                                break;
                            if (column == 16)
                            {
                                column = 0;
                                y += 5;
                                x = 0;
                            }
                            myBrush.Color = ((PictureBox)item).BackColor;
                            g.FillRectangle(myBrush, new Rectangle(x, y, 5, 5));
                            pic.Invalidate();
                            x += 5;
                            column++;
                            amount++;
                        }
                        myBrush.Dispose();
                        g.Dispose();
                        pic.Image.Save(sfd.FileName, ImageFormat.Png);
                    }
                    if (radioBtn16.Checked)
                    {
                        pic.Size = new Size(160, 160);
                        var bitmap = new Bitmap(pic.Width, pic.Height);
                        pic.Image = bitmap;
                        Graphics g = Graphics.FromImage(bitmap);
                        foreach (var item in Field.Controls)
                        {
                            if (amount == 1024)
                                break;
                            if (column == 32)
                            {
                                column = 0;
                                y += 5;
                                x = 0;
                            }
                            myBrush.Color = ((PictureBox)item).BackColor;
                            g.FillRectangle(myBrush, new Rectangle(x, y, 5, 5));
                            pic.Invalidate();
                            x += 5;
                            column++;
                            amount++;
                        }
                        myBrush.Dispose();
                        g.Dispose();
                        pic.Image.Save(sfd.FileName);
                    }
                }
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyArt())
            {
                QuestionForm qf = new QuestionForm();
                if (qf.ShowDialog() == DialogResult.OK)
                {
                    сохранитьToolStripMenuItem_Click(sender, e);
                    Field.Controls.Clear();
                    LoadMap();
                }
                else if (qf.DialogResult == DialogResult.Ignore)
                {
                    Field.Controls.Clear();
                    LoadMap();
                }
            }
            else
            {
                Field.Controls.Clear();
                LoadMap();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Можно открывать только те рисунки которые вы сохраняли", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Все файлы изображений(*.BMP;*.PNG;*.JPEG)|*.BMP;*.PNG;*.JPG|PNG|*.png|JPEG|*.jpg;*.jpeg;*.jpe;*.jfif|BMP|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp;
                float stepX, stepY;
                int amount = 0, x = 0, y = 0, column = 0;
                if (radioBtn16.Checked)
                {
                    bmp = new Bitmap(Image.FromFile(ofd.FileName));
                    stepX = (float)bmp.Size.Width / 16;
                    stepY = (float)bmp.Size.Height / 16;
                    if (stepX == 5 && stepY == 5)
                    {
                        foreach (var item in Field.Controls)
                        {
                            if (amount == 256)
                                break;
                            if (column == 16)
                            {
                                column = 0;
                                y += 5;
                                x = 0;
                            }
                            ((PictureBox)item).BackColor = bmp.GetPixel(x, y);
                            x += 5;
                            column++;
                            amount++;
                        }
                    }
                    else
                    {
                        if (stepX > 10 && stepY > 10)
                        {
                            MessageBox.Show("У данного изображения слишком большой размер выберите другое.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (stepX < 5 && stepY < 5)
                        {
                            MessageBox.Show("У данного изображения слишком маленький размер выберите другое.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (stepX == 10 && stepY == 10)
                        {
                            MessageBox.Show("Чтобы загрузить данное изображение выберите другой размер поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                if (radioBtn32.Checked)
                {
                    bmp = new Bitmap(Image.FromFile(ofd.FileName));
                    stepX = (float)bmp.Size.Width / 32;
                    stepY = (float)bmp.Size.Height / 32;
                    if (stepX == 5 && stepY == 5)
                    {
                        foreach (var item in Field.Controls)
                        {
                            if (amount == 1024)
                                break;
                            if (column == 32)
                            {
                                column = 0;
                                y += 5;
                                x = 0;
                            }
                            ((PictureBox)item).BackColor = bmp.GetPixel(x, y);
                            x += 5;
                            column++;
                            amount++;
                        }
                    }
                    else
                    {
                        if (stepX > 5 && stepY > 5)
                        {
                            MessageBox.Show("У данного изображения слишком большой размер выберите другое.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (stepX < 2.5 && stepY < 2.5)
                        {
                            MessageBox.Show("У данного изображения слишком маленький размер выберите другое.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else if (stepX == 2.5 && stepY == 2.5)
                        {
                            MessageBox.Show("Чтобы загрузить данное изображение выберите другой размер поля.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }
    }
}
