import java.util.Scanner;


public class RectangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Enter side a of the rectangle: ");
		int a = input.nextInt();
		System.out.println("Enter side b of the rectangle: ");
		int b = input.nextInt();
		System.out.println("The area of the rectangle is " + a*b);
	}

}
