namespace FibonacciDemo
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.buttonCalculate = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.label1 = new System.Windows.Forms.Label();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.buttonCalculateWithMemory = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(35, 75);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(111, 641);
      this.listBox1.TabIndex = 0;
      // 
      // buttonCalculate
      // 
      this.buttonCalculate.Location = new System.Drawing.Point(319, 75);
      this.buttonCalculate.Name = "buttonCalculate";
      this.buttonCalculate.Size = new System.Drawing.Size(126, 23);
      this.buttonCalculate.TabIndex = 1;
      this.buttonCalculate.Text = "Calculate Recursive";
      this.buttonCalculate.UseVisualStyleBackColor = true;
      this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.progressBar1.Location = new System.Drawing.Point(0, 722);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(519, 23);
      this.progressBar1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 45);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "label1";
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.Location = new System.Drawing.Point(184, 75);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(111, 641);
      this.listBox2.TabIndex = 4;
      // 
      // buttonCalculateWithMemory
      // 
      this.buttonCalculateWithMemory.Location = new System.Drawing.Point(319, 118);
      this.buttonCalculateWithMemory.Name = "buttonCalculateWithMemory";
      this.buttonCalculateWithMemory.Size = new System.Drawing.Size(126, 23);
      this.buttonCalculateWithMemory.TabIndex = 5;
      this.buttonCalculateWithMemory.Text = "Calculate with memory";
      this.buttonCalculateWithMemory.UseVisualStyleBackColor = true;
      this.buttonCalculateWithMemory.Click += new System.EventHandler(this.CalculateWithMemoryClick);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(181, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "label2";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(519, 745);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.buttonCalculateWithMemory);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.buttonCalculate);
      this.Controls.Add(this.listBox1);
      this.Name = "FormMain";
      this.Text = "How to calculate a Fibonacci number";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button buttonCalculate;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.Button buttonCalculateWithMemory;
    private System.Windows.Forms.Label label2;
  }
}

