import java.util.Scanner;

public class _3_WineGlass {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		int m = 0;
		int n = num - 2;
		for (int i = 0; i < num / 2; i++) {
			String dots = new String(new char[m]).replace("\0", ".");
			String asterix = new String(new char[n]).replace("\0", "*");
			System.out.println(dots + "\\" + asterix + "/" + dots);
			m++;
			n -= 2;
		}
		m--;
		for (int i = 0; i < (num - 1) / 2; i++) {
			String dots = new String(new char[m]).replace("\0", ".");
			System.out.println(dots + "||" + dots);
		}
		String dash = new String(new char[num]).replace("\0", "-");
		System.out.println(dash);
		if (num >= 12) {
			System.out.println(dash);
		}
	}
}
