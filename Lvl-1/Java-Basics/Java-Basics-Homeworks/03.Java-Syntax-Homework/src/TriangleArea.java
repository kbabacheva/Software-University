import java.util.Scanner;


public class TriangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String first = input.nextLine();
		String[] firstArray = first.split(" ");
		int aX = Integer.parseInt(firstArray[0]);
		int aY = Integer.parseInt(firstArray[1]);
		String second = input.nextLine();
		String[] secondArray = second.split(" ");
		int bX = Integer.parseInt(secondArray[0]);
		int bY = Integer.parseInt(secondArray[1]);
		String third = input.nextLine();
		String[] thirdArray = third.split(" ");
		int cX = Integer.parseInt(thirdArray[0]);
		int cY = Integer.parseInt(thirdArray[1]);
		int area = (aX*(bY - cY) + bX*(cY - aY) + cX*(aY - bY))/2;
		if (area >= 0) {
			System.out.println(area);
		}
		else {
			System.out.println(area*-1);
		}
	}

}
