import java.util.Scanner;

/**
 * Created by lucky on 10/15/2015.
 */
public class TriangleArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int aX = sc.nextInt();
        int aY = sc.nextInt();
        int bX = sc.nextInt();
        int bY = sc.nextInt();
        int cX = sc.nextInt();
        int cY = sc.nextInt();
        int numerator = aX*(bY-cY) + bX*(cY-aY) + cX*(aY-bY);
        double result = Math.abs((double) numerator / 2);
        int res = (int)result;
        System.out.println(res);
    }
}
