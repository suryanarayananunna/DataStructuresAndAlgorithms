public class Day01 {
    public static void findMaxMin(int[] arr) {
        int max = arr[0];
        int min = arr[0];
        
        for (int i = 1; i < arr.length; i++) {
            if (arr[i] > max) {
                max = arr[i];
            }
            if (arr[i] < min) {
                min = arr[i];
            }
        }
        
        System.out.println("Maximum: " + max);
        System.out.println("Minimum: " + min);
    }

    public static void main(String[] args) {
        int[] arr = { 5, 9, 3, 7, 2, 1 };
        findMaxMin(arr);
    }
}
