
namespace Vegetarian_Community
{
    partial class Community
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.posts = new System.Windows.Forms.GroupBox();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.GroupBox();
            this.addUser = new System.Windows.Forms.Button();
            this.sex = new System.Windows.Forms.GroupBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.l_age = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.l_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.l_id = new System.Windows.Forms.Label();
            this.titlePost = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.posts.SuspendLayout();
            this.users.SuspendLayout();
            this.sex.SuspendLayout();
            this.SuspendLayout();
            // 
            // posts
            // 
            this.posts.Controls.Add(this.backBtn);
            this.posts.Controls.Add(this.info);
            this.posts.Controls.Add(this.titlePost);
            this.posts.Controls.Add(this.forwardBtn);
            this.posts.Location = new System.Drawing.Point(12, 12);
            this.posts.Name = "posts";
            this.posts.Size = new System.Drawing.Size(575, 562);
            this.posts.TabIndex = 1;
            this.posts.TabStop = false;
            this.posts.Text = "Обсуждение";
            this.posts.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Location = new System.Drawing.Point(519, 506);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(50, 50);
            this.forwardBtn.TabIndex = 2;
            this.forwardBtn.Text = ">";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // users
            // 
            this.users.Controls.Add(this.l_id);
            this.users.Controls.Add(this.textBox1);
            this.users.Controls.Add(this.l_name);
            this.users.Controls.Add(this.name);
            this.users.Controls.Add(this.id);
            this.users.Controls.Add(this.l_age);
            this.users.Controls.Add(this.sex);
            this.users.Controls.Add(this.addUser);
            this.users.Location = new System.Drawing.Point(626, 12);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(444, 210);
            this.users.TabIndex = 2;
            this.users.TabStop = false;
            this.users.Text = "Пользователь";
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(6, 167);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(432, 37);
            this.addUser.TabIndex = 0;
            this.addUser.Text = "Присоединиться к обсуждению";
            this.addUser.UseVisualStyleBackColor = true;
            // 
            // sex
            // 
            this.sex.Controls.Add(this.female);
            this.sex.Controls.Add(this.male);
            this.sex.Location = new System.Drawing.Point(274, 25);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(164, 94);
            this.sex.TabIndex = 3;
            this.sex.TabStop = false;
            this.sex.Text = "Пол";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(22, 25);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(96, 24);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Мужчина";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(22, 55);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(103, 24);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "Женщина";
            this.female.UseVisualStyleBackColor = true;
            // 
            // l_age
            // 
            this.l_age.AutoSize = true;
            this.l_age.Location = new System.Drawing.Point(16, 132);
            this.l_age.Name = "l_age";
            this.l_age.Size = new System.Drawing.Size(70, 20);
            this.l_age.TabIndex = 5;
            this.l_age.Text = "Возраст";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(93, 45);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(175, 26);
            this.id.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(93, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(175, 26);
            this.name.TabIndex = 7;
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(16, 91);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(40, 20);
            this.l_name.TabIndex = 8;
            this.l_name.Text = "Имя";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 26);
            this.textBox1.TabIndex = 9;
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(16, 48);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(62, 20);
            this.l_id.TabIndex = 11;
            this.l_id.Text = "Номер";
            // 
            // titlePost
            // 
            this.titlePost.AutoSize = true;
            this.titlePost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titlePost.Location = new System.Drawing.Point(6, 41);
            this.titlePost.Name = "titlePost";
            this.titlePost.Size = new System.Drawing.Size(90, 21);
            this.titlePost.TabIndex = 5;
            this.titlePost.Text = "Заголовок";
            // 
            // info
            // 
            this.info.FormattingEnabled = true;
            this.info.ItemHeight = 20;
            this.info.Location = new System.Drawing.Point(6, 69);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(563, 424);
            this.info.TabIndex = 6;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(6, 506);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 50);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "<";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // Community
            // 
            this.ClientSize = new System.Drawing.Size(1344, 586);
            this.Controls.Add(this.users);
            this.Controls.Add(this.posts);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Community";
            this.posts.ResumeLayout(false);
            this.posts.PerformLayout();
            this.users.ResumeLayout(false);
            this.users.PerformLayout();
            this.sex.ResumeLayout(false);
            this.sex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox posts;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.GroupBox users;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.GroupBox sex;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label l_age;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label titlePost;
        private System.Windows.Forms.ListBox info;
        private System.Windows.Forms.Button backBtn;
    }
}

