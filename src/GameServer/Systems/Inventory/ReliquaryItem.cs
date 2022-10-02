﻿using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class ReliquaryItem : EquipItem
    {
		[BsonId] public int UniqueId { get; protected set; }
		[BsonElement] public int MainPropId { get; protected set; }
		[BsonIgnore] public new int Count { get; protected set; } = 1;
		public readonly List<int>? AppendPropIdList = new();
		public int EquippedAvatar; // By avatarId
		[BsonIgnore] public new ReliquaryData ItemData { get; protected set; }

		public ReliquaryItem(long guid, int itemId, int uniqueId) : base(guid, itemId)
		{
			UniqueId = uniqueId;
			Level = 1;

			// Create main property
			Random rand = new();
			ReliquaryMainPropData mainPropData = GameData.ReliquaryMainPropDataMap.ElementAt(rand.Next(0, GameData.ReliquaryMainPropDataMap.Count)).Value;
			MainPropId = mainPropData.id;

			// Create extra stats
			AppendPropIdList.Add(ItemData.appendPropNum);
		}

		public async Task OnLoadAsync(long guid)
		{
			ItemData = (ReliquaryData)GameData.ItemDataMap[ItemId];
			Guid = guid;
		}
		public EquipType GetEquipSlot()
		{
			return ItemData.equipType;
		}
		public Reliquary ToReliquaryProto()
		{
			Reliquary relic = new()
			{
				Level = (uint)Level,
				Exp = (uint)Exp,
				PromoteLevel = (uint)PromoteLevel,
				MainPropId = (uint)MainPropId,
			};
			foreach(int id in AppendPropIdList)
            {
				relic.AppendPropIdList.Add((uint)id);
            }

			return relic;
		}

		public SceneReliquaryInfo CreateSceneReliquaryInfo()
		{
			SceneReliquaryInfo relicInfo = new SceneReliquaryInfo()
			{
				ItemId = (uint)ItemId,
				Guid = (ulong)Guid,
				Level = (uint)Level
			};

			return relicInfo;
		}

		public override Item ToProto()
        {
            throw new NotImplementedException();
        }
    }
}