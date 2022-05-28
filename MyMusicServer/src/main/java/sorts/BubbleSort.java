/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package sorts;

/**
 *
 * @author ismae
 */
public class BubbleSort {
    
    public static void main(String[] args) {
        /**
         * Clase la cual contiene una funcion de ejemplo de bubblesort con varios datos
         */
        BubbleSort ob = new BubbleSort();
        int arr[] = {123342,23452,34,3452,235,523452,23452,2452,2345,2452,435,2424,524,242,5534};
        ob.bubbleSort(arr);
        System.out.println("Array acomodado:");
        ob.printArray(arr);
    }
    
    void bubbleSort(int[] arr){
        int n = arr.length;
        for (int i = 0; i < n-1; i++){
            for(int j = 0; j < n - i - 1; j++){
                if (arr[j] > arr[j+1]){
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
            
        }
    }
    void printArray(int arr[]){
        int n = arr.length;
        for (int i = 0; i < n; i++){
            System.out.println(arr[i]+" ");
            System.out.println();
        }
    }
}
