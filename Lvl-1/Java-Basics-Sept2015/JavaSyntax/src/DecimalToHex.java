import java.util.Scanner;

/**
 * Created by lucky on 10/15/2015.
 */
public class DecimalToHex {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num = sc.nextInt();
        String hex = Integer.toHexString(num).toUpperCase();
        System.out.print(hex);
    }
}
