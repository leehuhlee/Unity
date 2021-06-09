using Google.Protobuf.Protocol;
using Microsoft.EntityFrameworkCore;
using Server.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Game
{
	public class Player : GameObject
	{
		public int PlayerDbId { get; set; }
		public ClientSession Session { get; set; }

		public Player()
		{
			ObjectType = GameObjectType.Player;
		}

		public override void OnDamaged(GameObject attacker, int damage)
		{
			base.OnDamaged(attacker, damage);
		}

		public override void OnDead(GameObject attacker)
		{
			base.OnDead(attacker);
		}

		public void OnLeaveGame()
		{
			// TODO
			// DB 연동?
			// -- 피가 깎일 때마다 DB 접근할 필요가 있을까?
			// 1) 서버 다운되면 아직 저장되지 않은 정보 날아감
			// 2) 코드 흐름을 다 막아버린다 !!!!
			// - 비동기(Async) 방법 사용?
			// - 다른 쓰레드로 DB 일감을 던져버리면 되지 않을까?
			// -- 결과를 받아서 이어서 처리를 해야 하는 경우가 많음.
			// -- 아이템 생성

			DbTransaction.SavePlayerStatus_Step1(this, Room);
		}
	}
}
