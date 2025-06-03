namespace WeatherApp;

partial class Form1
{

    // ...existing code...
private System.Windows.Forms.Label labelLat;
private System.Windows.Forms.Label labelLon;
private System.Windows.Forms.TextBox textBoxLat;
private System.Windows.Forms.TextBox textBoxLon;
private System.Windows.Forms.Button buttonFetch;
private System.Windows.Forms.TextBox textBoxResult;
// ...existing code...

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
        this.labelLat = new System.Windows.Forms.Label();
        this.labelLon = new System.Windows.Forms.Label();
        this.textBoxLat = new System.Windows.Forms.TextBox();
        this.textBoxLon = new System.Windows.Forms.TextBox();
        this.buttonFetch = new System.Windows.Forms.Button();
        this.textBoxResult = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // labelLat
        // 
        this.labelLat.AutoSize = true;
        this.labelLat.Location = new System.Drawing.Point(30, 30);
        this.labelLat.Name = "labelLat";
        this.labelLat.Size = new System.Drawing.Size(61, 15);
        this.labelLat.TabIndex = 0;
        this.labelLat.Text = "Latitude:";
        // 
        // labelLon
        // 
        this.labelLon.AutoSize = true;
        this.labelLon.Location = new System.Drawing.Point(30, 70);
        this.labelLon.Name = "labelLon";
        this.labelLon.Size = new System.Drawing.Size(69, 15);
        this.labelLon.TabIndex = 1;
        this.labelLon.Text = "Longitude:";
        // 
        // textBoxLat
        // 
        this.textBoxLat.Location = new System.Drawing.Point(110, 27);
        this.textBoxLat.Name = "textBoxLat";
        this.textBoxLat.Size = new System.Drawing.Size(120, 23);
        this.textBoxLat.TabIndex = 2;
        // 
        // textBoxLon
        // 
        this.textBoxLon.Location = new System.Drawing.Point(110, 67);
        this.textBoxLon.Name = "textBoxLon";
        this.textBoxLon.Size = new System.Drawing.Size(120, 23);
        this.textBoxLon.TabIndex = 3;
        // 
        // buttonFetch
        // 
        this.buttonFetch.Location = new System.Drawing.Point(250, 27);
        this.buttonFetch.Name = "buttonFetch";
        this.buttonFetch.Size = new System.Drawing.Size(120, 63);
        this.buttonFetch.TabIndex = 4;
        this.buttonFetch.Text = "Get Forecast";
        this.buttonFetch.UseVisualStyleBackColor = true;
        this.buttonFetch.Click += new System.EventHandler(this.buttonFetch_Click);
        // 
        // textBoxResult
        // 
        this.textBoxResult.Location = new System.Drawing.Point(30, 110);
        this.textBoxResult.Multiline = true;
        this.textBoxResult.Name = "textBoxResult";
        this.textBoxResult.ReadOnly = true;
        this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.textBoxResult.Size = new System.Drawing.Size(340, 250);
        this.textBoxResult.TabIndex = 5;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(400, 400);
        this.Controls.Add(this.labelLat);
        this.Controls.Add(this.labelLon);
        this.Controls.Add(this.textBoxLat);
        this.Controls.Add(this.textBoxLon);
        this.Controls.Add(this.buttonFetch);
        this.Controls.Add(this.textBoxResult);
        this.Name = "Form1";
        this.Text = "Weather Forecast";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}
