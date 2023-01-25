
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
            this.post = new System.Windows.Forms.GroupBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.ListBox();
            this.l_title_post = new System.Windows.Forms.Label();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.GroupBox();
            this.age = new System.Windows.Forms.TextBox();
            this.l_name = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.l_age = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.addUser = new System.Windows.Forms.Button();
            this.posts = new System.Windows.Forms.GroupBox();
            this.addPost = new System.Windows.Forms.Button();
            this.p_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.p_user_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comments = new System.Windows.Forms.GroupBox();
            this.addComment = new System.Windows.Forms.Button();
            this.c_user_id = new System.Windows.Forms.TextBox();
            this.c_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.post.SuspendLayout();
            this.users.SuspendLayout();
            this.sex.SuspendLayout();
            this.posts.SuspendLayout();
            this.comments.SuspendLayout();
            this.SuspendLayout();
            // 
            // post
            // 
            this.post.Controls.Add(this.backBtn);
            this.post.Controls.Add(this.info);
            this.post.Controls.Add(this.l_title_post);
            this.post.Controls.Add(this.forwardBtn);
            this.post.Location = new System.Drawing.Point(12, 119);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(575, 537);
            this.post.TabIndex = 1;
            this.post.TabStop = false;
            this.post.Text = "Обсуждение";
            this.post.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(6, 481);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(50, 50);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "<";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // info
            // 
            this.info.FormattingEnabled = true;
            this.info.ItemHeight = 20;
            this.info.Location = new System.Drawing.Point(6, 69);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(563, 404);
            this.info.TabIndex = 6;
            this.info.SelectedIndexChanged += new System.EventHandler(this.info_SelectedIndexChanged);
            // 
            // l_title_post
            // 
            this.l_title_post.AutoSize = true;
            this.l_title_post.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_title_post.Location = new System.Drawing.Point(6, 41);
            this.l_title_post.Name = "l_title_post";
            this.l_title_post.Size = new System.Drawing.Size(0, 21);
            this.l_title_post.TabIndex = 5;
            // 
            // forwardBtn
            // 
            this.forwardBtn.Location = new System.Drawing.Point(519, 481);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(50, 50);
            this.forwardBtn.TabIndex = 2;
            this.forwardBtn.Text = ">";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // users
            // 
            this.users.Controls.Add(this.age);
            this.users.Controls.Add(this.l_name);
            this.users.Controls.Add(this.name);
            this.users.Controls.Add(this.l_age);
            this.users.Controls.Add(this.sex);
            this.users.Controls.Add(this.addUser);
            this.users.Location = new System.Drawing.Point(606, 13);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(444, 178);
            this.users.TabIndex = 2;
            this.users.TabStop = false;
            this.users.Text = "Пользователь";
            this.users.Enter += new System.EventHandler(this.users_Enter);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(83, 82);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(175, 26);
            this.age.TabIndex = 9;
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(6, 44);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(40, 20);
            this.l_name.TabIndex = 8;
            this.l_name.Text = "Имя";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(83, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(175, 26);
            this.name.TabIndex = 7;
            // 
            // l_age
            // 
            this.l_age.AutoSize = true;
            this.l_age.Location = new System.Drawing.Point(6, 85);
            this.l_age.Name = "l_age";
            this.l_age.Size = new System.Drawing.Size(70, 20);
            this.l_age.TabIndex = 5;
            this.l_age.Text = "Возраст";
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
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
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
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(6, 131);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(432, 37);
            this.addUser.TabIndex = 0;
            this.addUser.Text = "Присоединиться к сообществу";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // posts
            // 
            this.posts.Controls.Add(this.addPost);
            this.posts.Controls.Add(this.p_title);
            this.posts.Controls.Add(this.label2);
            this.posts.Controls.Add(this.p_user_id);
            this.posts.Controls.Add(this.label1);
            this.posts.Location = new System.Drawing.Point(12, 13);
            this.posts.Name = "posts";
            this.posts.Size = new System.Drawing.Size(455, 100);
            this.posts.TabIndex = 3;
            this.posts.TabStop = false;
            this.posts.Text = "Создать новое обсуждение";
            this.posts.Enter += new System.EventHandler(this.posts_Enter);
            // 
            // addPost
            // 
            this.addPost.Location = new System.Drawing.Point(295, 21);
            this.addPost.Name = "addPost";
            this.addPost.Size = new System.Drawing.Size(151, 66);
            this.addPost.TabIndex = 8;
            this.addPost.Text = "Задать вопрос";
            this.addPost.UseVisualStyleBackColor = true;
            this.addPost.Click += new System.EventHandler(this.addPost_Click);
            // 
            // p_title
            // 
            this.p_title.Location = new System.Drawing.Point(79, 61);
            this.p_title.Name = "p_title";
            this.p_title.Size = new System.Drawing.Size(197, 26);
            this.p_title.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вопрос";
            // 
            // p_user_id
            // 
            this.p_user_id.Location = new System.Drawing.Point(176, 21);
            this.p_user_id.Name = "p_user_id";
            this.p_user_id.Size = new System.Drawing.Size(100, 26);
            this.p_user_id.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер пользователя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comments
            // 
            this.comments.Controls.Add(this.addComment);
            this.comments.Controls.Add(this.c_user_id);
            this.comments.Controls.Add(this.c_text);
            this.comments.Controls.Add(this.label3);
            this.comments.Location = new System.Drawing.Point(606, 214);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(289, 170);
            this.comments.TabIndex = 4;
            this.comments.TabStop = false;
            this.comments.Text = "Комментарий";
            // 
            // addComment
            // 
            this.addComment.Location = new System.Drawing.Point(15, 104);
            this.addComment.Name = "addComment";
            this.addComment.Size = new System.Drawing.Size(255, 45);
            this.addComment.TabIndex = 3;
            this.addComment.Text = "Ответить";
            this.addComment.UseVisualStyleBackColor = true;
            this.addComment.Click += new System.EventHandler(this.addComment_Click);
            // 
            // c_user_id
            // 
            this.c_user_id.Location = new System.Drawing.Point(181, 36);
            this.c_user_id.Name = "c_user_id";
            this.c_user_id.Size = new System.Drawing.Size(89, 26);
            this.c_user_id.TabIndex = 2;
            // 
            // c_text
            // 
            this.c_text.Location = new System.Drawing.Point(15, 72);
            this.c_text.Name = "c_text";
            this.c_text.Size = new System.Drawing.Size(255, 26);
            this.c_text.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номер пользователя";
            // 
            // Community
            // 
            this.ClientSize = new System.Drawing.Size(1061, 663);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.posts);
            this.Controls.Add(this.users);
            this.Controls.Add(this.post);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Community";
            this.Load += new System.EventHandler(this.Community_Load);
            this.post.ResumeLayout(false);
            this.post.PerformLayout();
            this.users.ResumeLayout(false);
            this.users.PerformLayout();
            this.sex.ResumeLayout(false);
            this.sex.PerformLayout();
            this.posts.ResumeLayout(false);
            this.posts.PerformLayout();
            this.comments.ResumeLayout(false);
            this.comments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox post;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.GroupBox users;
        private System.Windows.Forms.GroupBox sex;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label l_age;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label l_title_post;
        private System.Windows.Forms.ListBox info;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.GroupBox posts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPost;
        private System.Windows.Forms.TextBox p_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox p_user_id;
        private System.Windows.Forms.GroupBox comments;
        private System.Windows.Forms.Button addComment;
        private System.Windows.Forms.TextBox c_user_id;
        private System.Windows.Forms.TextBox c_text;
        private System.Windows.Forms.Label label3;
    }
}

