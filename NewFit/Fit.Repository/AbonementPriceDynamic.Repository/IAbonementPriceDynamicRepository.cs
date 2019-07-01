using System.Collections.Generic;

namespace NewFit
{
    public interface IAbonementPriceDynamicRepository
    {
        void Delete(int id);
        AbonementPriceDynamicData GetDetails(int id);
        List<AbonementPriceDynamicData> GetList(int id);
        void Insert(AbonementPriceDynamicData det);
        void Update(AbonementPriceDynamicData det);
    }
}