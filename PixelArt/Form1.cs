using System;
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
        private bool CallFunction = true; //Для контролю виклику функції збереження
        private static int count = 1; // Для контролю палітри
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
            int x;
            int y;
            int cord = 0;

            if (radioBtn16.Checked)
            {
                cord = 44;
            }
            else if (radioBtn32.Checked)
            {
                cord = 22;
            }

            foreach (var item in Field.Controls)
            {
                x = ((PictureBox)item).Location.X;
                y = ((PictureBox)item).Location.Y;
                if (p.X == x && p.Y == y)
                {
                    ((PictureBox)item).BackColor = RightColor;
                    continue;
                }
                if (p.X == x && p.Y - cord == y && ((PictureBox)item).BackColor == FoneColor)
                {
                    Fill(new Point(x, y));
                }
                if (p.X + cord == x && p.Y == y && ((PictureBox)item).BackColor == FoneColor)
                {
                    Fill(new Point(x, y));
                }
                if (p.X == x && p.Y + cord == y && ((PictureBox)item).BackColor == FoneColor)
                {
                    Fill(new Point(x, y));
                }
                if (p.X - cord == x && p.Y == y && ((PictureBox)item).BackColor == FoneColor)
                {
                    Fill(new Point(x, y));
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
            int x;
            int y;
            int count = 0;
            int divCord = 0;
            int numberOfPixels = 0;
            Color color = Color.Empty;

            FirstCord = (Point)sender.GetType().GetProperty("Location").GetValue(sender);

            if (radioBtn16.Checked)
            {
                divCord = 40;
                numberOfPixels = 256;
            }
            else if (radioBtn32.Checked)
            {
                divCord = 20;
                numberOfPixels = 1024;
            }

            switch (currItem)
            {
                case item.Pencil:
                    {
                        if (IsPressedLeft == true)
                        {
                            color = LeftColor;
                        }
                        else if (IsPressedRight == true)
                        {
                            color = RightColor;
                        }

                        foreach (var item in Field.Controls)
                        {
                            if (item is PictureBox)
                            {
                                if (count == numberOfPixels)
                                    break;

                                x = ((PictureBox)item).Location.X;
                                y = ((PictureBox)item).Location.Y;

                                if (e.X + FirstCord.X >= x && e.X + FirstCord.X <= x + divCord &&
                                    e.Y + FirstCord.Y >= y && e.Y + FirstCord.Y <= y + divCord)
                                {
                                    ((PictureBox)item).BackColor = color;
                                    break;
                                }
                                count++;
                            }
                        }

                        break;
                    }
                case item.Erase:
                    {
                        if (IsPressedLeft == true)
                        {
                            foreach (var item in Field.Controls)
                            {
                                if (item is PictureBox)
                                {
                                    if (count == numberOfPixels)
                                        break;

                                    x = ((PictureBox)item).Location.X;
                                    y = ((PictureBox)item).Location.Y;

                                    if (e.X + FirstCord.X >= x && e.X + FirstCord.X <= x + divCord &&
                                        e.Y + FirstCord.Y >= y && e.Y + FirstCord.Y <= y + divCord)
                                    {
                                        ((PictureBox)item).BackColor = RightColor;
                                        break;
                                    }
                                    count++;
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
            int n = 0;
            int size = 0;
            int step = 0;

            if (radioBtn16.Checked)
            {
                n = 16;
                size = 40;
                step = 4;
            }
            if (radioBtn32.Checked)
            {
                n = 32;
                size = 20;
                step = 2;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Size = new Size(size, size);
                    pic.Location = new Point(step + (step + size) * j, step + (step + size) * i);
                    pic.BackColor = Color.White;
                    pic.MouseClick += PixelMouseClick;
                    pic.MouseDown += PixelMouseDown;
                    pic.MouseMove += PixelMouseMove;
                    pic.MouseUp += PixelMouseUp;
                    Field.Controls.Add(pic);
                }
            }
        }

        private void LoadMap() // Функція для загрузки поля
        {
            int n = 0;
            int size = 0;
            int step = 0;

            SetPixel();

            if (radioBtn16.Checked)
            {
                n = 16;
                size = 40;
                step = 4;
            }
            if (radioBtn32.Checked)
            {
                n = 32;
                size = 20;
                step = 2;
            }

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.BackColor = Color.Black;
                    pic.Location = new Point(0, (size + step) * i);
                    pic.Size = new Size(n * size + (n + 1) * step, step);
                    Field.Controls.Add(pic);
                }
                for (int j = 0; j <= n; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.BackColor = Color.Black;
                    pic.Location = new Point((size + step) * i, 0);
                    pic.Size = new Size(step, n * size + (n + 1) * step);
                    Field.Controls.Add(pic);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMap();
        }

        private bool CheckEmptyArt() // Функція для перевірки чи пусте зараз поле
        {
            int count = 0;
            int numberOfPixels = 0;

            if (radioBtn16.Checked)
            {
                numberOfPixels = 256;
            }
            else if (radioBtn32.Checked)
            {
                numberOfPixels = 1024;
            }

            foreach (var item in Field.Controls)
            {
                if (count == numberOfPixels)
                    break;

                if (((PictureBox)item).BackColor != Color.White)
                    return false;

                count++;
            }
            return true;
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
            int count = 0;
            int numberOfPixels = 0;

            if (radioBtn16.Checked)
            {
                numberOfPixels = 256;
            }
            else if (radioBtn32.Checked)
            {
                numberOfPixels = 1024;
            }

            foreach (var item in Field.Controls)
            {
                if (count == numberOfPixels)
                    break;

                ((PictureBox)item).BackColor = Color.White;
                count++;
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
