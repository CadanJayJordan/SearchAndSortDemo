
namespace SearchAndSortProject {
    partial class FRMSearchAndSort {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.DGVArray = new System.Windows.Forms.DataGridView();
            this.DGVColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNRandom = new System.Windows.Forms.Button();
            this.BTNDispArray = new System.Windows.Forms.Button();
            this.BTNLinearSearchSorted = new System.Windows.Forms.Button();
            this.TXTLinearSearchForSorted = new System.Windows.Forms.TextBox();
            this.GBXLinearSearchSorted = new System.Windows.Forms.GroupBox();
            this.LBLLinearFoundSorted = new System.Windows.Forms.Label();
            this.TXTLinearSearchFoundSorted = new System.Windows.Forms.TextBox();
            this.LBLLinearSearchForSorted = new System.Windows.Forms.Label();
            this.GBXLinearSearchUnsorted = new System.Windows.Forms.GroupBox();
            this.LBLLinearFoundUnsorted = new System.Windows.Forms.Label();
            this.TXTLinearSearchFoundUnsorted = new System.Windows.Forms.TextBox();
            this.LBLLinearSearchForUnsorted = new System.Windows.Forms.Label();
            this.BTNLinearSearchUnsorted = new System.Windows.Forms.Button();
            this.TXTLinearSearchForUnsorted = new System.Windows.Forms.TextBox();
            this.BTNBubbleSort = new System.Windows.Forms.Button();
            this.GBXBinarySearch = new System.Windows.Forms.GroupBox();
            this.LBLBinarySearchFound = new System.Windows.Forms.Label();
            this.TXTBinarySearchFound = new System.Windows.Forms.TextBox();
            this.LBLBinarySearchFor = new System.Windows.Forms.Label();
            this.BTNBinarySearch = new System.Windows.Forms.Button();
            this.TXTBinarySearchFor = new System.Windows.Forms.TextBox();
            this.BTNInsertionSort = new System.Windows.Forms.Button();
            this.GBXSorting = new System.Windows.Forms.GroupBox();
            this.btnQuickSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArray)).BeginInit();
            this.GBXLinearSearchSorted.SuspendLayout();
            this.GBXLinearSearchUnsorted.SuspendLayout();
            this.GBXBinarySearch.SuspendLayout();
            this.GBXSorting.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVArray
            // 
            this.DGVArray.AllowUserToAddRows = false;
            this.DGVArray.AllowUserToDeleteRows = false;
            this.DGVArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArray.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVColumnIndex,
            this.DGVColumnData});
            this.DGVArray.Location = new System.Drawing.Point(93, 12);
            this.DGVArray.Name = "DGVArray";
            this.DGVArray.ReadOnly = true;
            this.DGVArray.Size = new System.Drawing.Size(244, 384);
            this.DGVArray.TabIndex = 0;
            // 
            // DGVColumnIndex
            // 
            this.DGVColumnIndex.HeaderText = "Index";
            this.DGVColumnIndex.Name = "DGVColumnIndex";
            this.DGVColumnIndex.ReadOnly = true;
            // 
            // DGVColumnData
            // 
            this.DGVColumnData.HeaderText = "Data";
            this.DGVColumnData.Name = "DGVColumnData";
            this.DGVColumnData.ReadOnly = true;
            // 
            // BTNRandom
            // 
            this.BTNRandom.Location = new System.Drawing.Point(12, 12);
            this.BTNRandom.Name = "BTNRandom";
            this.BTNRandom.Size = new System.Drawing.Size(75, 42);
            this.BTNRandom.TabIndex = 1;
            this.BTNRandom.Text = "Random Number";
            this.BTNRandom.UseVisualStyleBackColor = true;
            this.BTNRandom.Click += new System.EventHandler(this.BTNRandom_Click);
            // 
            // BTNDispArray
            // 
            this.BTNDispArray.Location = new System.Drawing.Point(12, 60);
            this.BTNDispArray.Name = "BTNDispArray";
            this.BTNDispArray.Size = new System.Drawing.Size(75, 42);
            this.BTNDispArray.TabIndex = 2;
            this.BTNDispArray.Text = "Display Array";
            this.BTNDispArray.UseVisualStyleBackColor = true;
            this.BTNDispArray.Click += new System.EventHandler(this.BTNDispArray_Click);
            // 
            // BTNLinearSearchSorted
            // 
            this.BTNLinearSearchSorted.Location = new System.Drawing.Point(116, 58);
            this.BTNLinearSearchSorted.Name = "BTNLinearSearchSorted";
            this.BTNLinearSearchSorted.Size = new System.Drawing.Size(68, 23);
            this.BTNLinearSearchSorted.TabIndex = 3;
            this.BTNLinearSearchSorted.Text = "Search";
            this.BTNLinearSearchSorted.UseVisualStyleBackColor = true;
            this.BTNLinearSearchSorted.Click += new System.EventHandler(this.BTNLinearSearchSorted_Click);
            // 
            // TXTLinearSearchForSorted
            // 
            this.TXTLinearSearchForSorted.Location = new System.Drawing.Point(6, 32);
            this.TXTLinearSearchForSorted.Name = "TXTLinearSearchForSorted";
            this.TXTLinearSearchForSorted.Size = new System.Drawing.Size(178, 20);
            this.TXTLinearSearchForSorted.TabIndex = 4;
            this.TXTLinearSearchForSorted.Text = "TXTLinearSearchForSorted";
            // 
            // GBXLinearSearchSorted
            // 
            this.GBXLinearSearchSorted.Controls.Add(this.LBLLinearFoundSorted);
            this.GBXLinearSearchSorted.Controls.Add(this.TXTLinearSearchFoundSorted);
            this.GBXLinearSearchSorted.Controls.Add(this.LBLLinearSearchForSorted);
            this.GBXLinearSearchSorted.Controls.Add(this.BTNLinearSearchSorted);
            this.GBXLinearSearchSorted.Controls.Add(this.TXTLinearSearchForSorted);
            this.GBXLinearSearchSorted.Location = new System.Drawing.Point(343, 12);
            this.GBXLinearSearchSorted.Name = "GBXLinearSearchSorted";
            this.GBXLinearSearchSorted.Size = new System.Drawing.Size(190, 125);
            this.GBXLinearSearchSorted.TabIndex = 5;
            this.GBXLinearSearchSorted.TabStop = false;
            this.GBXLinearSearchSorted.Text = "Linear Search (Sorted)";
            // 
            // LBLLinearFoundSorted
            // 
            this.LBLLinearFoundSorted.AutoSize = true;
            this.LBLLinearFoundSorted.Location = new System.Drawing.Point(9, 80);
            this.LBLLinearFoundSorted.Name = "LBLLinearFoundSorted";
            this.LBLLinearFoundSorted.Size = new System.Drawing.Size(40, 13);
            this.LBLLinearFoundSorted.TabIndex = 7;
            this.LBLLinearFoundSorted.Text = "Found:";
            this.LBLLinearFoundSorted.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TXTLinearSearchFoundSorted
            // 
            this.TXTLinearSearchFoundSorted.Location = new System.Drawing.Point(6, 99);
            this.TXTLinearSearchFoundSorted.Name = "TXTLinearSearchFoundSorted";
            this.TXTLinearSearchFoundSorted.ReadOnly = true;
            this.TXTLinearSearchFoundSorted.Size = new System.Drawing.Size(178, 20);
            this.TXTLinearSearchFoundSorted.TabIndex = 6;
            this.TXTLinearSearchFoundSorted.Text = "TXTLinearSearchFoundSorted";
            // 
            // LBLLinearSearchForSorted
            // 
            this.LBLLinearSearchForSorted.AutoSize = true;
            this.LBLLinearSearchForSorted.Location = new System.Drawing.Point(6, 16);
            this.LBLLinearSearchForSorted.Name = "LBLLinearSearchForSorted";
            this.LBLLinearSearchForSorted.Size = new System.Drawing.Size(62, 13);
            this.LBLLinearSearchForSorted.TabIndex = 5;
            this.LBLLinearSearchForSorted.Text = "Search For:";
            // 
            // GBXLinearSearchUnsorted
            // 
            this.GBXLinearSearchUnsorted.Controls.Add(this.LBLLinearFoundUnsorted);
            this.GBXLinearSearchUnsorted.Controls.Add(this.TXTLinearSearchFoundUnsorted);
            this.GBXLinearSearchUnsorted.Controls.Add(this.LBLLinearSearchForUnsorted);
            this.GBXLinearSearchUnsorted.Controls.Add(this.BTNLinearSearchUnsorted);
            this.GBXLinearSearchUnsorted.Controls.Add(this.TXTLinearSearchForUnsorted);
            this.GBXLinearSearchUnsorted.Location = new System.Drawing.Point(343, 143);
            this.GBXLinearSearchUnsorted.Name = "GBXLinearSearchUnsorted";
            this.GBXLinearSearchUnsorted.Size = new System.Drawing.Size(190, 125);
            this.GBXLinearSearchUnsorted.TabIndex = 8;
            this.GBXLinearSearchUnsorted.TabStop = false;
            this.GBXLinearSearchUnsorted.Text = "Linear Search (Unsorted)";
            // 
            // LBLLinearFoundUnsorted
            // 
            this.LBLLinearFoundUnsorted.AutoSize = true;
            this.LBLLinearFoundUnsorted.Location = new System.Drawing.Point(9, 80);
            this.LBLLinearFoundUnsorted.Name = "LBLLinearFoundUnsorted";
            this.LBLLinearFoundUnsorted.Size = new System.Drawing.Size(40, 13);
            this.LBLLinearFoundUnsorted.TabIndex = 7;
            this.LBLLinearFoundUnsorted.Text = "Found:";
            this.LBLLinearFoundUnsorted.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TXTLinearSearchFoundUnsorted
            // 
            this.TXTLinearSearchFoundUnsorted.Location = new System.Drawing.Point(6, 99);
            this.TXTLinearSearchFoundUnsorted.Name = "TXTLinearSearchFoundUnsorted";
            this.TXTLinearSearchFoundUnsorted.ReadOnly = true;
            this.TXTLinearSearchFoundUnsorted.Size = new System.Drawing.Size(178, 20);
            this.TXTLinearSearchFoundUnsorted.TabIndex = 6;
            this.TXTLinearSearchFoundUnsorted.Text = "TXTLinearSearchFoundUnsorted";
            // 
            // LBLLinearSearchForUnsorted
            // 
            this.LBLLinearSearchForUnsorted.AutoSize = true;
            this.LBLLinearSearchForUnsorted.Location = new System.Drawing.Point(6, 16);
            this.LBLLinearSearchForUnsorted.Name = "LBLLinearSearchForUnsorted";
            this.LBLLinearSearchForUnsorted.Size = new System.Drawing.Size(62, 13);
            this.LBLLinearSearchForUnsorted.TabIndex = 5;
            this.LBLLinearSearchForUnsorted.Text = "Search For:";
            // 
            // BTNLinearSearchUnsorted
            // 
            this.BTNLinearSearchUnsorted.Location = new System.Drawing.Point(116, 58);
            this.BTNLinearSearchUnsorted.Name = "BTNLinearSearchUnsorted";
            this.BTNLinearSearchUnsorted.Size = new System.Drawing.Size(68, 23);
            this.BTNLinearSearchUnsorted.TabIndex = 3;
            this.BTNLinearSearchUnsorted.Text = "Search";
            this.BTNLinearSearchUnsorted.UseVisualStyleBackColor = true;
            this.BTNLinearSearchUnsorted.Click += new System.EventHandler(this.BTNLinearSearchUnsorted_Click);
            // 
            // TXTLinearSearchForUnsorted
            // 
            this.TXTLinearSearchForUnsorted.Location = new System.Drawing.Point(6, 32);
            this.TXTLinearSearchForUnsorted.Name = "TXTLinearSearchForUnsorted";
            this.TXTLinearSearchForUnsorted.Size = new System.Drawing.Size(178, 20);
            this.TXTLinearSearchForUnsorted.TabIndex = 4;
            this.TXTLinearSearchForUnsorted.Text = "TXTLinearSearchForUnsorted";
            // 
            // BTNBubbleSort
            // 
            this.BTNBubbleSort.Location = new System.Drawing.Point(0, 23);
            this.BTNBubbleSort.Name = "BTNBubbleSort";
            this.BTNBubbleSort.Size = new System.Drawing.Size(75, 42);
            this.BTNBubbleSort.TabIndex = 9;
            this.BTNBubbleSort.Text = "Bubble\r\nSort";
            this.BTNBubbleSort.UseVisualStyleBackColor = true;
            this.BTNBubbleSort.Click += new System.EventHandler(this.BTNBubbleSort_Click);
            // 
            // GBXBinarySearch
            // 
            this.GBXBinarySearch.Controls.Add(this.LBLBinarySearchFound);
            this.GBXBinarySearch.Controls.Add(this.TXTBinarySearchFound);
            this.GBXBinarySearch.Controls.Add(this.LBLBinarySearchFor);
            this.GBXBinarySearch.Controls.Add(this.BTNBinarySearch);
            this.GBXBinarySearch.Controls.Add(this.TXTBinarySearchFor);
            this.GBXBinarySearch.Location = new System.Drawing.Point(343, 274);
            this.GBXBinarySearch.Name = "GBXBinarySearch";
            this.GBXBinarySearch.Size = new System.Drawing.Size(190, 125);
            this.GBXBinarySearch.TabIndex = 9;
            this.GBXBinarySearch.TabStop = false;
            this.GBXBinarySearch.Text = "Binary Search (Sorted)";
            // 
            // LBLBinarySearchFound
            // 
            this.LBLBinarySearchFound.AutoSize = true;
            this.LBLBinarySearchFound.Location = new System.Drawing.Point(9, 80);
            this.LBLBinarySearchFound.Name = "LBLBinarySearchFound";
            this.LBLBinarySearchFound.Size = new System.Drawing.Size(40, 13);
            this.LBLBinarySearchFound.TabIndex = 7;
            this.LBLBinarySearchFound.Text = "Found:";
            this.LBLBinarySearchFound.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TXTBinarySearchFound
            // 
            this.TXTBinarySearchFound.Location = new System.Drawing.Point(6, 99);
            this.TXTBinarySearchFound.Name = "TXTBinarySearchFound";
            this.TXTBinarySearchFound.ReadOnly = true;
            this.TXTBinarySearchFound.Size = new System.Drawing.Size(178, 20);
            this.TXTBinarySearchFound.TabIndex = 6;
            this.TXTBinarySearchFound.Text = "TXTBinarySearchFound";
            // 
            // LBLBinarySearchFor
            // 
            this.LBLBinarySearchFor.AutoSize = true;
            this.LBLBinarySearchFor.Location = new System.Drawing.Point(6, 16);
            this.LBLBinarySearchFor.Name = "LBLBinarySearchFor";
            this.LBLBinarySearchFor.Size = new System.Drawing.Size(62, 13);
            this.LBLBinarySearchFor.TabIndex = 5;
            this.LBLBinarySearchFor.Text = "Search For:";
            // 
            // BTNBinarySearch
            // 
            this.BTNBinarySearch.Location = new System.Drawing.Point(116, 58);
            this.BTNBinarySearch.Name = "BTNBinarySearch";
            this.BTNBinarySearch.Size = new System.Drawing.Size(68, 23);
            this.BTNBinarySearch.TabIndex = 3;
            this.BTNBinarySearch.Text = "Search";
            this.BTNBinarySearch.UseVisualStyleBackColor = true;
            this.BTNBinarySearch.Click += new System.EventHandler(this.BTNBinarySearch_Click);
            // 
            // TXTBinarySearchFor
            // 
            this.TXTBinarySearchFor.Location = new System.Drawing.Point(6, 32);
            this.TXTBinarySearchFor.Name = "TXTBinarySearchFor";
            this.TXTBinarySearchFor.Size = new System.Drawing.Size(178, 20);
            this.TXTBinarySearchFor.TabIndex = 4;
            this.TXTBinarySearchFor.Text = "TXTBinarySearchFor";
            // 
            // BTNInsertionSort
            // 
            this.BTNInsertionSort.Location = new System.Drawing.Point(0, 71);
            this.BTNInsertionSort.Name = "BTNInsertionSort";
            this.BTNInsertionSort.Size = new System.Drawing.Size(75, 42);
            this.BTNInsertionSort.TabIndex = 10;
            this.BTNInsertionSort.Text = "Insertion Sort";
            this.BTNInsertionSort.UseVisualStyleBackColor = true;
            this.BTNInsertionSort.Click += new System.EventHandler(this.BTNInsertionSort_Click);
            // 
            // GBXSorting
            // 
            this.GBXSorting.Controls.Add(this.btnQuickSort);
            this.GBXSorting.Controls.Add(this.BTNInsertionSort);
            this.GBXSorting.Controls.Add(this.BTNBubbleSort);
            this.GBXSorting.Location = new System.Drawing.Point(12, 111);
            this.GBXSorting.Name = "GBXSorting";
            this.GBXSorting.Size = new System.Drawing.Size(75, 170);
            this.GBXSorting.TabIndex = 11;
            this.GBXSorting.TabStop = false;
            this.GBXSorting.Text = "Sorting";
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(0, 119);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(75, 42);
            this.btnQuickSort.TabIndex = 11;
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // FRMSearchAndSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 408);
            this.Controls.Add(this.GBXSorting);
            this.Controls.Add(this.GBXBinarySearch);
            this.Controls.Add(this.GBXLinearSearchUnsorted);
            this.Controls.Add(this.GBXLinearSearchSorted);
            this.Controls.Add(this.BTNDispArray);
            this.Controls.Add(this.BTNRandom);
            this.Controls.Add(this.DGVArray);
            this.Name = "FRMSearchAndSort";
            this.Text = "Search And Sort";
            this.Load += new System.EventHandler(this.FRMSearchAndSort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVArray)).EndInit();
            this.GBXLinearSearchSorted.ResumeLayout(false);
            this.GBXLinearSearchSorted.PerformLayout();
            this.GBXLinearSearchUnsorted.ResumeLayout(false);
            this.GBXLinearSearchUnsorted.PerformLayout();
            this.GBXBinarySearch.ResumeLayout(false);
            this.GBXBinarySearch.PerformLayout();
            this.GBXSorting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVArray;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVColumnData;
        private System.Windows.Forms.Button BTNRandom;
        private System.Windows.Forms.Button BTNDispArray;
        private System.Windows.Forms.Button BTNLinearSearchSorted;
        private System.Windows.Forms.TextBox TXTLinearSearchForSorted;
        private System.Windows.Forms.GroupBox GBXLinearSearchSorted;
        private System.Windows.Forms.Label LBLLinearFoundSorted;
        private System.Windows.Forms.TextBox TXTLinearSearchFoundSorted;
        private System.Windows.Forms.Label LBLLinearSearchForSorted;
        private System.Windows.Forms.GroupBox GBXLinearSearchUnsorted;
        private System.Windows.Forms.Label LBLLinearFoundUnsorted;
        private System.Windows.Forms.TextBox TXTLinearSearchFoundUnsorted;
        private System.Windows.Forms.Label LBLLinearSearchForUnsorted;
        private System.Windows.Forms.Button BTNLinearSearchUnsorted;
        private System.Windows.Forms.TextBox TXTLinearSearchForUnsorted;
        private System.Windows.Forms.Button BTNBubbleSort;
        private System.Windows.Forms.GroupBox GBXBinarySearch;
        private System.Windows.Forms.Label LBLBinarySearchFound;
        private System.Windows.Forms.TextBox TXTBinarySearchFound;
        private System.Windows.Forms.Label LBLBinarySearchFor;
        private System.Windows.Forms.Button BTNBinarySearch;
        private System.Windows.Forms.TextBox TXTBinarySearchFor;
        private System.Windows.Forms.Button BTNInsertionSort;
        private System.Windows.Forms.GroupBox GBXSorting;
        private System.Windows.Forms.Button btnQuickSort;
    }
}

