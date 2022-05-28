/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package sorts;

/**
 *
 * @author ismae
 */
public class InsertionSort {
    public static void main(String[] args) {
        int arr[] = {21345,235,3452,2345,43,11,1435,312432,23452,234524,23452,333};
        InsertionSort ob = new InsertionSort();
        ob.sort(arr);
        printArray(arr);
    }
    void sort(int arr[]){
        int n = arr.length;
        for (int i = 1; i < n; i++){
            int key = arr[i];
            int j = i - 1;
            
            while(j>=0 && arr[j] > key){
                arr[j+1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        } 
        
    }
    
    static void printArray(int arr[]){
        int n = arr.length;
        for (int i = 0; i < n; i++){
            System.out.println(arr[i]+" ");
            System.out.println();    
        }
    }
    
    
}
