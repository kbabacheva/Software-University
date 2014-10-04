package exam2;

import java.util.Scanner;
 
public class Program2 {
 
        public static void main(String[] args) {
                Scanner input = new Scanner(System.in);
                double x = input.nextDouble();
                double y = input.nextDouble();
               
                if (x == 0 && y == 0) {
                        System.out.println("0");
                }
                else if (x == 0) {
                        System.out.println("5");
                }
                else if (y == 0) {
                        System.out.println("6");
                }
                else if (x > 0 && y > 0) {
                        System.out.println("1");
                }
                else if (x < 0 && y > 0) {
                        System.out.println("2");
                }
                else if (x < 0 && y < 0) {
                        System.out.println("3");
                }
                else if (x > 0 && y < 0) {
                        System.out.println("4");
                }
                input.close();
        }
 
}
