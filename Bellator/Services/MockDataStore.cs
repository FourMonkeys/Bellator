using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bellator.Models;

namespace Bellator.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;
        Levels levels = new Levels();
        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 1", Description= String.Format("XP:{0,6}     {1, 20}ACP: {2}", levels.LevelOne.XP, "", levels.LevelOne.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 2", Description= String.Format("XP:{0,6}   {1, 20}ACP: {2}", levels.LevelTwo.XP, "", levels.LevelTwo.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 3", Description= String.Format("XP:{0,6}   {1, 20}ACP: {2}", levels.LevelThree.XP, "", levels.LevelThree.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 4", Description= String.Format("XP:{0,6}   {1, 20}ACP: {2}", levels.LevelFour.XP, "", levels.LevelFour.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 5", Description= String.Format("XP:{0,6}   {1, 20}ACP: {2}", levels.LevelFive.XP, "", levels.LevelFive.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 6", Description= String.Format("XP:{0,6}  {1, 20}ACP: {2}", levels.LevelSix.XP, "", levels.LevelSix.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 7", Description= String.Format("XP:{0,6}  {1, 20}ACP: {2}", levels.LevelSeven.XP, "", levels.LevelSeven.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 8", Description= String.Format("XP:{0,6}  {1, 20}ACP: {2}", levels.LevelEight.XP, "", levels.LevelEight.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 9", Description= String.Format("XP:{0,6}  {1, 20}ACP: {2}", levels.LevelNine.XP, "", levels.LevelNine.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 10", Description= String.Format("XP:{0,6}  {1, 20}ACP: {2}", levels.LevelTen.XP, "", levels.LevelTen.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 11", Description= String.Format("XP:{0,6}  {1, 20}ACP: {2}", levels.LevelEleven.XP, "", levels.LevelEleven.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 12", Description= String.Format("XP:{0,6} {1, 20}ACP: {2}", levels.LevelTwelve.XP, "", levels.LevelTwelve.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 13", Description= String.Format("XP:{0,6} {1, 20}ACP: {2}", levels.LevelThirteen.XP, "", levels.LevelThirteen.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 14", Description= String.Format("XP:{0,6} {1, 20}ACP: {2}", levels.LevelFourteen.XP, "", levels.LevelFourteen.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 15", Description= String.Format("XP:{0,6} {1, 20}ACP: {2}", levels.LevelFifteen.XP, "", levels.LevelFifteen.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 16", Description= String.Format("XP:{0,6} {1, 20}ACP: {2}", levels.LevelSixteen.XP, "", levels.LevelSixteen.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 17", Description= String.Format("XP:{0,6} {1, 20}ACP: {2}", levels.LevelSeventeen.XP, "", levels.LevelSeventeen.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 18", Description= String.Format("XP:{0,6} {1, 20}ACP: {2}", levels.LevelEighteen.XP, "", levels.LevelEighteen.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 19", Description= String.Format("XP:{0,6} {1, 20}ACP: {2}", levels.LevelNineteen.XP, "", levels.LevelNineteen.ACP) },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Level 20", Description= String.Format("XP:{0,6} {1, 20}ACP: {2}", levels.LevelTwenty.XP, "", levels.LevelTwenty.ACP) }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}