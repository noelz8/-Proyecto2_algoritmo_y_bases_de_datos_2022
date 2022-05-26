/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package sorts;

/**
 *
 * @author ismae
 */
public class QuickSort {

    /**
     *
     * @param args
     */
    public static void main(String[] args) {
        int [] arr = {10,25,7,3,22,3,44,900,222,2345,2};
        int n = arr.length;
        
        quickSort(arr, 0, n-1);
        System.out.println("El array ordenado es:");
        printArray(arr, n);
    }
    
    static void swap(int[] arr, int i, int j){
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    
    static int particion(int[] arr, int low, int high){
        int pivot = arr[high];
        
        int i = (low-1);
        
        for(int j = low; j<=high-1; j++){
            if(arr[j]<pivot){
                i++;
                swap(arr,i,j);
                
            }
        }
        swap(arr,i+1,high);
        return (i+1);
    }
    
    static void quickSort(int[] arr, int low, int high){
        if(low < high){
            int pi = particion(arr,low,high);
            quickSort(arr, low, pi+1);
            quickSort(arr, pi+1, high);
        }
    }
    
    static void printArray(int[] arr, int size){
        for(int i = 0; i < size; i++){
            System.out.println(arr[i]+" ");
            System.out.println();
        }
        
        
    }
    
    
}
