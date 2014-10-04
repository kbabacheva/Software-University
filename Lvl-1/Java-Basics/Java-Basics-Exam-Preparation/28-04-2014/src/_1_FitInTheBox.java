import java.util.Scanner;

public class _1_FitInTheBox {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		long a1 = input.nextLong();
		long a2 = input.nextLong();
		long a3 = input.nextLong();
		long b1 = input.nextLong();
		long b2 = input.nextLong();
		long b3 = input.nextLong();
		long volumeA = a1*a2*a3;
		long volumeB = b1*b2*b3;
		if (volumeA > volumeB) {
			if (a1>b1&&a2>b2&&a3>b3) {
				System.out.println("(" + b1 + ", " + b2 + ", " + b3 + ") < (" + a1 + ", " + a2 + ", " + a3 + ")");
			}
			if (a1>b1&&a2>b3&&a3>b2) {
				System.out.println("(" + b1 + ", " + b2 + ", " + b3 + ") < (" + a1 + ", " + a3 + ", " + a2 + ")");
			}
			if (a1>b2&&a2>b1&&a3>b3) {
				System.out.println("(" + b1 + ", " + b2 + ", " + b3 + ") < (" + a2 + ", " + a1 + ", " + a3 + ")");
			}
			if (a1>b3&&a2>b1&&a3>b2) {
				System.out.println("(" + b1 + ", " + b2 + ", " + b3 + ") < (" + a2 + ", " + a3 + ", " + a1 + ")");
			}
			if (a1>b2&&a2>b3&&a3>b1) {
				System.out.println("(" + b1 + ", " + b2 + ", " + b3 + ") < (" + a3 + ", " + a1 + ", " + a2 + ")");
			}
			if (a1>b3&&a2>b2&&a3>b1) {
				System.out.println("(" + b1 + ", " + b2 + ", " + b3 + ") < (" + a3 + ", " + a2 + ", " + a1 + ")");
			}
		}
		else if (volumeA < volumeB){
			if (b1>a1&&b2>a2&&b3>a3) {
				System.out.println("(" + a1 + ", " + a2 + ", " + a3 + ") < (" + b1 + ", " + b2 + ", " + b3 + ")");
			}
			if (b1>a1&&b2>a3&&b3>a2) {
				System.out.println("(" + a1 + ", " + a2 + ", " + a3 + ") < (" + b1 + ", " + b3 + ", " + b2 + ")");
			}
			if (b1>a2&&b2>a1&&b3>a3) {
				System.out.println("(" + a1 + ", " + a2 + ", " + a3 + ") < (" + b2 + ", " + b1 + ", " + b3 + ")");
			}
			if (b1>a3&&b2>a1&&b3>a2) {
				System.out.println("(" + a1 + ", " + a2 + ", " + a3 + ") < (" + b2 + ", " + b3 + ", " + b1 + ")");
			}
			if (b1>a2&&b2>a3&&b3>a1) {
				System.out.println("(" + a1 + ", " + a2 + ", " + a3 + ") < (" + b3 + ", " + b1 + ", " + b2 + ")");
			}
			if (b1>a3&&b2>a2&&b3>a1) {
				System.out.println("(" + a1 + ", " + a2 + ", " + a3 + ") < (" + b3 + ", " + b2 + ", " + b1 + ")");
			}
		}
		else {
			System.out.println("");
		}
	}
}
