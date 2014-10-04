import java.util.Scanner;

public class _1_InsideTheBuilding {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int h = input.nextInt();
		for (int i = 0; i < 5; i++) {
			int x = input.nextInt();
			int y = input.nextInt();
			if (((y >=0 && y <= h) && (x >= 0 && x <= 3*h)) || ((y >= 0 && y <= 4*h) && (x >= h && x <= 2*h))){
				System.out.println("inside");
			}
			else {
				System.out.println("outside");
			}
		}
	}
}
