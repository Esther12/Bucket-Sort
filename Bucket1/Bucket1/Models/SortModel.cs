using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Bucket1.Models
{
    public class SortModel
    {
        public string Input { get; set; }

        public void Main(string[] args)
        {

            int[] arr = Input.Split(',').Select(Int32.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            string stg = "";
            for (int i = 0; i < arr.Length; i++)
            {
                string a = String.Format("{0},", arr);
                stg += a;
            }
        }
    }

}


        
