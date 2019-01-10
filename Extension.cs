using System;

namespace DeepakExtensionMethods
{
    public static class ExtensionMethods
    {
        public static float Sum(this float[] GenericArray)
        {
            float sum=default(float);
            for(int i=0; i< GenericArray.Length; i++)
            {
                sum=sum+GenericArray[i];
            }
            return sum;
        }

        public static int Sum(this int[] GenericArray)
        {
            int sum=default(int);
            for(int i=0; i< GenericArray.Length; i++)
            {
                sum=sum+GenericArray[i];
            }
            return sum;
        }
    }
}