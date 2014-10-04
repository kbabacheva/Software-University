import java.util.Scanner;


public class _1_Triagle {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double ax = input.nextDouble();
		double ay = input.nextDouble();
		double bx = input.nextDouble();
		double by = input.nextDouble();
		double cx = input.nextDouble();
		double cy = input.nextDouble();
		//  System.out.printf("sqrt(%.3f) is %.3f%n", x, Math.sqrt(x));
		//distance a-b
		double ab = (bx - ax)*(bx - ax) + (by-ay)*(by-ay);
		double b = Math.sqrt(ab);
		//distance b-c
		double bc = (cx - bx)*(cx - bx) + (cy-by)*(cy-by);
		double c = Math.sqrt(bc);
		//distance c-a
		double ca = (ax - cx)*(ax - cx) + (ay-cy)*(ay-cy);
		double a = Math.sqrt(ca);
		double perimeter = (a+b+c)/2;
		double area = Math.sqrt(perimeter*(perimeter-a)*(perimeter-b)*(perimeter-c));
		if (a+b>c && b+c>a && a+c>b) {
			System.out.println("Yes");
			System.out.printf("%.2f",area);
		}
		else {
			System.out.println("No");
			System.out.printf("%.2f",b);
		}
	}
}
