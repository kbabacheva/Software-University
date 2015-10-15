import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by lucky on 10/15/2015.
 */
public class SmallestOf3Numbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num = 3;
        double[] arr = new double[num];
        for (int i = 0; i < num; i++) {
            arr[i] = sc.nextDouble();
        }
        Arrays.sort(arr);
        System.out.println(fmt(arr[0]));
    }
    public static String fmt(double d)
    {
        if(d == (long) d)
            return String.format("%d",(long)d);
        else
            return String.format("%s",d);
    }
}
