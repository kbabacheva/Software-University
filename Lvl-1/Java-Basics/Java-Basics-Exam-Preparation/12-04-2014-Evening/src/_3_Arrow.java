
public class _3_Arrow {

	public static void main(String[] args) {
		int num = 3;
		String dots = new String(new char[num/2]).replace("\0",".");
		String dash = new String(new char[num]).replace("\0","#");
		System.out.println(dots + dash + dots);
		//upper part
		for (int i = 0; i < num-2; i++) {
			String outterDots = new String(new char[num/2]).replace("\0",".");
			String innerDots = new String(new char[num-2]).replace("\0",".");
			System.out.println(outterDots + "#" + innerDots + "#" + outterDots);
		}
		//middle
		int width = 2*num - 1;
		int dotsCount = num-2;
		int dashCount = (width-dotsCount)/2;
		dots = new String(new char[dotsCount]).replace("\0",".");
		dash = new String(new char[dashCount]).replace("\0","#");
		System.out.println(dash + dots + dash);
		//end
		int outterDotsCount = 1;
		int innerDotsCount = width - 2 - 2*outterDotsCount;
		for (int i = 0; i < num-2; i++) {
			String outterDots = new String(new char[outterDotsCount]).replace("\0",".");
			String innerDots = new String(new char[innerDotsCount]).replace("\0",".");
			System.out.println(outterDots + "#" + innerDots + "#" + outterDots);
			outterDotsCount ++;
			innerDotsCount -=2;
		}
		dots = new String(new char[num-1]).replace("\0",".");
		System.out.println(dots + "#" + dots);
	}
}
