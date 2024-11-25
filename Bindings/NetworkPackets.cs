﻿namespace Bindings
{
    public enum ServerPackets
    {
        SAlertMsg = 1,
        SAllChars,
        SLoginOk,
        SNewCharClasses,
        SClassesData,
        SInGame,
        SPlayerInv,
        SPlayerInvUpdate,
        SPlayerWornEq,
        SPlayerHp,
        SPlayerMp,
        SPlayerSp,
        SPlayerStamina,
        SPlayerStats,
        SPlayerData,
        SPlayerMove,
        SNpcMove,
        SPlayerDir,
        SNpcDir,
        SPlayerExp,
        SAttack,
        SNpcAttack,
        SCheckForRoom,
        SRoomData,
        SRoomItemData,
        SRoomNpcData,
        SRoomDone,
        SSayMsg,
        SGlobalMsg,
        SAdminMsg,
        SPlayerMsg,
        SRoomMsg,
        SSpawnItem,
        SItemEditor,
        SUpdateItem,
        SEditItem,
        SREditor,
        SSpawnNpc,
        SNpcDead,
        SNpcEditor,
        SUpdateNpc,
        SEditNpc,
        SEditRoom,
        SShopEditor,
        SUpdateShop,
        SEditShop,
        SSpellEditor,
        SUpdateSpell,
        SEditSpell,
        STrade,
        SSpells,
        SLeft,
        SHighIndex,
        SCastSpell,
        SSendMaxes,
        SSync,
        SRoomRevs,
        //The following enum member automatically stores the number of messages,
        //since it is last. Any new messages must be placed above this entry.
        SMSG_COUNT
    }
    public enum ClientPackets
    {
        CGetClasses = 1,
        CNewAccount,
        CDelAccount,
        CLogin,
        CAddChar,
        CDelChar,
        CUseChar,
        CSayMsg,
        CEmoteMsg,
        CBroadcastMsg,
        CGlobalMsg,
        CAdminMsg,
        CPlayerMsg,
        CPlayerMove,
        CPlayerDir,
        CUseItem,
        CAttack,
        CUseStatPoint,
        CPlayerInfoRequest,
        CWarpMeTo,
        CWarpToMe,
        CWarpTo,
        CSetAvatar,
        CGetStats,
        CRequestNewRoom,
        CRoomData,
        CNeedRoom,
        CRoomGetItem,
        CRoomDropItem,
        CRoomRespawn,
        CRoomReport,
        CKickPlayer,
        CBanList,
        CBanDestroy,
        CBanPlayer,
        CRequestEditRoom,
        CRequestEditItem,
        CEditItem,
        CSaveItem,
        CRequestEditNpc,
        CEditNpc,
        CSaveNpc,
        CRequestEditShop,
        CEditShop,
        CSaveShop,
        CRequestEditSpell,
        CEditSpell,
        CSaveSpell,
        CDelete,
        CSetAccess,
        CWhosOnline,
        CSetMotd,
        CTrade,
        CTradeRequest,
        CFixItem,
        CSearch,
        CParty,
        CJoinParty,
        CLeaveParty,
        CSpells,
        CCast,
        CQuit,
        CSync,
        CRoomReqs,
        CSleepInn,
        CRemoveFromGuild,
        CCreateGuild,
        CInviteGuild,
        CKickGuild,
        CGuildPromote,
        CLeaveGuild,
        //The following enum member automatically stores the number of messages,
        //since it is last. Any new messages must be placed above this entry.
        CMSG_COUNT
    }
}
