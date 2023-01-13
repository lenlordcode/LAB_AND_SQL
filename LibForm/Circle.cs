namespace LibForm
{
    
    public static class FormCounting
    {
        public static float getSquareCircle (float radius)
        {
            if (radius < 0)
                throw new ArgumentException("Ошибка, неправильное число: " + radius );

            return ((float)Math.PI) * (radius * 2);
        }
        public static float getSquareArea (float a, float b, float c)
        {
            return (a + b + c)/2;
        }
    }
}