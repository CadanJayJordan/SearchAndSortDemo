using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SearchAndSortProject {
    public partial class FRMSearchAndSort : Form {

        private const int initArraySize = 10; // Constsant array size
        private const int maxRanNumber = 20; // Constant maximum random number
        private int[] array = new int[initArraySize];// {12, 7, 3, 14, 13, 5, 20, 2, 17}; // New integer array of size 10 (0-9)
        public FRMSearchAndSort() {
            InitializeComponent();
        }

        private void FRMSearchAndSort_Load(object sender, EventArgs e) {
            // Clear TXT Boxes
            TXTLinearSearchForSorted.Text = "";
            TXTLinearSearchForUnsorted.Text = "";
            TXTLinearSearchFoundSorted.Text = "";
            TXTLinearSearchFoundUnsorted.Text = "";
            TXTBinarySearchFor.Text = "";
            TXTBinarySearchFound.Text = "";


            DGVArray.RowCount = array.Length; // Set Row Count To Array Size
            // Add an item to the DGV until it reaches the max array size
            for (int i = 0; i <= array.Length - 1; i++) {
                DGVArray[0, i].Value = i + 1;

            }

        }

        private void BTNRandom_Click(object sender, EventArgs e) {
            Random rand = new Random(); // Create a new Random Instance

            // Generates random numbers and inserts into array
            for (int i = 0; i <= array.Length - 1;  i++) {
                array[i] = rand.Next(maxRanNumber);
            }
        }

        private void BTNDispArray_Click(object sender, EventArgs e) {
           
            for (int i = 0; i <= array.Length-1; i++) {
                // If the array count differes from the DGV Row count
                if (DGVArray.RowCount != array.Length) {
                    // Find difference between the array length and row count
                    int difference = array.Length - DGVArray.RowCount;
                    // if the difference is positive
                    if (difference > 0) {
                        // Add new rows to dgv, amoutn of new rows = difference
                        // Also ensure that the count in the index column of the dgv is correct.
                        for (int x = 1; x <= difference; x++) {
                            int newRowIndex = DGVArray.Rows.Add();
                            DGVArray[0, newRowIndex].Value = newRowIndex + 1;
                        }
                    // If difference is negative
                    } else if (difference < 0) {
                        // Remove rows from bottom, rows removed = difference
                        // (For loop looks different as it is going negative as the difference is negative)
                        for (int x = 0; x >= difference; x--) {
                            DGVArray.Rows.RemoveAt(DGVArray.Rows.Count -1);
                        }
                    }
                }
                // Getting each item in the array and adding it to the DGV
                DGVArray[1, i].Value = array[i];
            }
        }

        private void BTNLinearSearchSorted_Click(object sender, EventArgs e) {
            // Declarations
            bool entryFound = false;
            int foundIndex = 0;
            // Get Search For Entery from search box
            int entry = textBoxToInt(TXTLinearSearchForSorted);

            // Loop for i is every item in the array
            for (int i = 0; i <= array.Length - 1; i++) {
                // Is entery = to array item and is in list, if so break and share the printed index
                if (entry == array[i]) {
                    entryFound = true;
                    foundIndex = i + 1;
                    break;
                    // If the entry is less than the array in a sorted list, we don't need to search any further.
                } else if (entry < array[i]) {
                    break;
                }
            }

            // Set text to found state
            if (entryFound) {
                TXTLinearSearchFoundSorted.Text = entry + " found at Index: " + foundIndex;
                // Set text to not found state
            } else {
                TXTLinearSearchFoundSorted.Text = entry + " not found";
            } 
        }

        private void BTNLinearSearchUnsorted_Click(object sender, EventArgs e) {
            // Declarations
            bool entryFound = false;
            int foundIndex = 0;
            // Get Search For Entery from search box
            int entry = textBoxToInt(TXTLinearSearchForUnsorted);

            // Loop for i is every item in the array
            for (int i = 0; i <= array.Length - 1; i++) {
                // Is entery = to array item, if so break and share the printed index
                if (entry == array[i]) {
                    entryFound = true;
                    foundIndex = i + 1;
                    break;
                }
            }
            // Set text to found state
            if (entryFound) {
                TXTLinearSearchFoundUnsorted.Text = entry + " found at Index: " + foundIndex;
            // Set text to not found state
            } else {
                TXTLinearSearchFoundUnsorted.Text = entry + " not found";
            }
        }

        private void BTNBubbleSort_Click(object sender, EventArgs e) {
            // Declaration
            int numOfElements = array.Length;
            bool swapFlag = true;
            int swapTemp;

            // While swap flag is true or number of elements is not 0
            while (swapFlag || !(numOfElements == 0)) {
                // Set swap flag to false
                swapFlag = false;
                // For Loop to length of array - 1
                for (int i = 0; i < numOfElements - 1; i++) {
                    // If the element is larger than the element + 1
                    if (array[i] > array[i + 1]) {
                        // Perform Swap
                        swapTemp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = swapTemp;
                        // Indicate swap has occursed so list is not sorted
                        swapFlag = true;
                    }
                    
                }
                // Deincriment number of elements to save on processing time
                numOfElements--;
            }

        }

        private void BTNBinarySearch_Click(object sender, EventArgs e) {
            // Declaration
            bool enteryFound = false;
            bool searchFailed = false;
            int endPtr = array.Length; //End Of Search
            int startPtr = 1; // Start OF Search
            int midPtr = 0; // Will be set to midpoint of search
            int searchTerm = textBoxToInt(TXTBinarySearchFor); // Get int from text box

            // While the entry is not found and the search has not failed
            while (!enteryFound && !searchFailed) {
                // Turn midpoint into a while number as you cant have half an index
                midPtr = Convert.ToInt32(Math.Truncate((double)((startPtr + endPtr) / 2)));
                // If the first items are equal then the entery is found
                if (array[midPtr] == searchTerm) {
                    enteryFound = true;
                    break;
                // If its not found on first go
                } else {
                    // If the start of the chop is bigger than the end it has failed
                    // and teh search term is not in the array
                    if (startPtr >= endPtr) {
                        searchFailed = true;
                        break;
                    // If it has not failed
                    } else {
                        // If the search term is larger, get rid of the lower part of the list;
                        // we know it is not in that part
                        if (array[midPtr] < searchTerm) {
                            startPtr = midPtr + 1;
                        // Else the serch term is smaller so get rid of the top of the list
                        } else {
                            endPtr = midPtr - 1;
                        }
                    }
                }
            }
            // Output found if it was reported as found
            if (enteryFound) {
                TXTBinarySearchFound.Text = searchTerm + " found at Index: " + (midPtr + 1).ToString();
            // Output faied if it has not been found
            } else if (searchFailed){
                TXTBinarySearchFound.Text = searchTerm + " not found";
            }
        }

        private void BTNInsertionSort_Click(object sender, EventArgs e) {
            
            // Shift all elements of the array 1 to the right to allow ISort to 
            // use postion 0 as a storage position without overwriting data.
            array = shiftElementsOfArray(1, array);

            // Declaration of element count
            int numOfElements = array.Length;

            // for For every element
            for (int i = 1; i <= numOfElements-1; i++) {
                // Make current element, the current element
                int currentElement = array[i];
                // Make position 0 of the array the current element
                array[0] = currentElement;
                // Use as a counter pointer
                int countPtr = i - 1;
                // Do comparision to see what is larger
                while (array[countPtr] > currentElement) {
                    // perform swap and deincriment counter pointer
                    array[countPtr + 1] = array[countPtr];
                    countPtr--;
                }
                // Move the inserted character the next position
                array[countPtr + 1] = currentElement;
            }
            // Shift array back so it is displayed corrctly without the last sorted number
            // at the start of the array (removes first element of array)
            array = shiftElementsOfArray(-1, array);
        }


        // Moves all elemnts in the array left or right (depending on if the shift amount is negative or positive respectivly)
        private int[] shiftElementsOfArray(int shiftAmount, int[] arrayIn) {
            // Create the a new array 
            int[] tempArray = new int[arrayIn.Length + shiftAmount];
            // The elemnt that we are working on
            int tempElement;

            // If the shift amount is posotive 
            if (shiftAmount > 0) {
                // Loops through how many times the array is to shift to the right
                for (int i = 0; i < shiftAmount; i++) {
                    // Loops through all elements of the array from the beginning
                    for (int x = 0; x <= arrayIn.Length-1; x++) {
                        tempArray[x + 1] = arrayIn[x]; // Gets element from existing array and adds it one position to the right in the new array
                    }
                }
            // If the shift amount is negative
            } else if (shiftAmount < 0) {
                // Loops through the amount of times to shift to the left
                for (int i = 0; i < shiftAmount * -1; i++) {
                    // Loops through all elements of the arrat from the end
                    for (int x = arrayIn.Length - 1; x > 0; x--) {
                        tempArray[x - 1] = arrayIn[x]; // gets element from exiting array and adds it one postion to the left in the new array
                    }
                    
                }
            }
            // return the new array
            return tempArray;
        }

        // Attempt to return the int in a text box's text field
        // If it cannot be done, -1 will be returned
        private int textBoxToInt(TextBox textBox) {
            int i = 0;
            try {
                i = Convert.ToInt32(textBox.Text);
            } catch (System.FormatException) {
                i = -1;
            }
            return i;
        }

        private void btnQuickSort_Click(object sender, EventArgs e) {
            qSort(0, array.Length - 1);
        }

        // Quick Sort
        private void qSort(int start, int end) { // start & end are list dimensions
            // Variable Init
            int tempSwapInt;
            int LIP = start;
            int HIP = end;
            int MIPVal = array[Convert.ToInt32((end + start) / 2)];
            // Repeat
            while (!(LIP > HIP)){
                // Finding items on the wrong side of hte MIP
                while (array[LIP] < MIPVal) {
                    LIP++;
                }
                while (MIPVal < array[HIP]) {
                    HIP--;
                }
                // Swap if either one pointer hits the middle, or both have an item on the wrong side.
                if (LIP <= HIP) {
                    // Perform Swap
                    tempSwapInt = array[LIP];
                    array[LIP] = array[HIP];
                    array[HIP] = tempSwapInt;
                    LIP++;
                    HIP--;
                }
            } 
            // Recurison
            if (start < HIP) {
                qSort(LIP, end);
            }
            if (LIP < end) {
                qSort(start, HIP);
            }
        }
    }
}
