namespace Restaurant_Mangement_System.BL
{
    class Employee
    {
        protected Credentials user = new Credentials();

        public Employee() { }
        public Employee(Credentials user)
        {
            this.user = user;
        }

        public Credentials getUser()
        {
            return this.user;
        }

        public void setUser(Credentials user)
        {
            this.user = user;
        }
        public virtual string toString()
        {
            return $"{user.UserName,-25}";
        }
    }
}
