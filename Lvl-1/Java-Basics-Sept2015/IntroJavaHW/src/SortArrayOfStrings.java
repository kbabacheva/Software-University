import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by lucky on 10/15/2015.
 */
public class SortArrayOfStrings {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num = sc.nextInt();
        sc.nextLine();
        String[] towns = new String[num];

        for (int i = 0; i < num; i++) {
            towns[i] = sc.nextLine();
        }
        Arrays.sort(towns);
        for (int i = 0; i < num; i++) {
            System.out.println(towns[i]);
        }
    }
}
