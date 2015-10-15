import java.util.Scanner;

/**
 * Created by lucky on 10/15/2015.
 */
public class PointInsideTheFigure {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double aX = sc.nextDouble();
        double aY = sc.nextDouble();
        String inside = "INSIDE";
        String outside = "OUTSIDE";
        if (aX < 12.5 || aX > 22.5 || aY < 6 || aY > 13.5){
            System.out.println(outside);
        }
        else if (aX > 17.5 && aX < 20 && aY > 8.5){
            System.out.println(outside);
        }
        else{
            System.out.println(inside);
        }
    }
}
