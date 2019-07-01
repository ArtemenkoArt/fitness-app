namespace NewFit
{
    public interface IAbonementIncomeRepository
    {
        void Delete(int id);
        void DeleteByClientAbonement(int id);
        AbonementIncomeData GetDetails(int id);
        void Insert(AbonementIncomeData det);
        void SetDelete(AbonementIncomeData det);
        void Update(AbonementIncomeData det);
    }
}