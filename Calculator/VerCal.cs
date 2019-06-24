namespace Calculator
{
    public class VerCal
    {
        public double Ver1=0;
        public double Ver2 = 0;
        public string VerOp = " ";
        
        
        public double Operate()
        {
            if (VerOp == "/")
            {
                double result = Ver1 / Ver2;
                return result;
            }
            else if (VerOp == "-")
            {
                double result = Ver1 - Ver2;
                return result;
            }
            else if (VerOp == "*")
            {
                double result = Ver1 * Ver2;
                return result;
            }
            else 
            {
                double result = Ver1 + Ver2;
                return result;
            }
        }
        
    }
}
