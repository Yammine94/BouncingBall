public class BouncingBall {
	
	public static int bouncingBall(double h, double bounce, double window) {
	      
            int count = 0;
            
            if (bounce <= 0 || bounce >= 1)
            {  return -1;  }
           
            else if(h <= 0 || window <= 0 || window >= h)
            {  return -1;  }           
            
            do
            { count += 2;
              h *= bounce;
            }
            while (window < h);

            return count -1;
     
	}
}