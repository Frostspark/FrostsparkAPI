using Frostspark.API.Classes;
using System;

namespace Frostspark.API.Packets
{
    /// <summary>
    /// Represents a game network packet.
    /// </summary>
    public abstract class BasePacket
    {
        
    }
    public enum Type : byte
    {
        /// <summary>
        /// An undefined packet
        /// </summary>
        None,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Connection handshake. Sent by the client when opening a connection, contains the version string.
        /// </summary>
        Connect = 1,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// A kick/disconnection packet. Contains the reason of disconnection.
        /// </summary>
        Disconnect = 2,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Networks the assigned slot (byte) to the client.
        /// </summary>
        AssignSlot = 3,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates a player's character data. Sent while connecting to initialize the player, and during play.
        /// </summary>
        PlayerCharacterData = 4,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates a player's inventory slots. Sent while connecting to initialize the player, and during play.
        /// </summary>
        PlayerInventorySlot = 5,
        /// <summary>
        /// <para>Client -&lt; Server</para>
        /// Requests world data from the server. Sent after character &amp; slot updates while connecting.
        /// </summary>
        WorldInfoRequest = 6,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Contains the world's data, including its <see cref="Guid"/>, name, defeated bosses, weather status and time.
        /// </summary>
        WorldInfoResponse = 7,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Requests a tile section (a "chunk") from the server. Both coordinates set to -1 indicate a spawn area request.
        /// </summary>
        TileSectionRequest = 8,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Sends a status text to the client, and the amount of packets through which the status text should persist. Statuses are shown on the connect screen &amp; the side of the game window.
        /// </summary>
        Status = 9,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Contains a section of tiles from the world map.
        /// </summary>
        TileBlock = 10,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Prompts the client to detect tileframes in all blocks in the specified section.
        /// </summary>
        SectionTileFrame = 11,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Spawns a player on the map at specified coordinates.
        /// </summary>
        PlayerSpawn = 12,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates a player's control and movement variables. (held keys, position, velocity, etc)
        /// </summary>
        PlayerUpdate = 13,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Activates or deactivates a player slot on a client's side. Used to signal a player connecting or disconnecting.
        /// </summary>
        PlayerActive = 14,
        [Obsolete("This packet has been removed from the game and is no longer supported.", true)]
        SyncPlayers = 15,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates a player's health variables. (current &amp; max health)
        /// </summary>
        PlayerHealth,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Edits a tile at specific coordinates.
        /// </summary>
        TileEdit,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Updates the world time and sun/moon offsets.
        /// </summary>
        TimeUpdate,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Opens or closes a door, trapdoor or gate.
        /// </summary>
        DoorInteract,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Contains a tile square (a square-shaped region of tiles) to be placed in the specified location
        /// </summary>
        TileSquare,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates, creates, or removes an item laying on the ground.
        /// </summary>
        UpdateItem,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates the owner of an item laying on the ground.
        /// </summary>
        UpdateItemOwner,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Updates an NPC's variables. (position, velocity, name, health etc.)
        /// </summary>
        UpdateNPC,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Damages an NPC with the player's held item.
        /// </summary>
        DamageNPCWithItem,
        /// <summary>
        /// Replaced by <see cref="Type.ChatText2"/>
        /// </summary>
        [Obsolete("This packet has been removed from the game and is no longer supported.", true)]
        ChatText,
        [Obsolete("This packet has been removed from the game and is no longer supported.", true)]
        PlayerDamage,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates or creates a projectile.
        /// </summary>
        UpdateProjectile,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Damages an NPC.
        /// </summary>
        DamageNPC,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Removes a projectile.
        /// </summary>
        RemoveProjectile,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Sets the player's PvP state.
        /// </summary>
        TogglePlayerPVP,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Requests a chest's contents.
        /// </summary>
        ChestRequest,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Synchronises an item in a chest.
        /// </summary>
        ChestItem,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Opens a chest, optionally setting its name.
        /// </summary>
        ChestOpen,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Places or removes a chest or dresser.
        /// </summary>
        ChestEdit,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Shows a heal effect (green floating numbers showing the amount of health restored) above a player.
        /// </summary>
        PlayerHealEffect,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates a player's biome location.
        /// </summary>
        PlayerZone,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Requests a password while connecting. Has no effect after logon.
        /// </summary>
        PasswordRequest,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Supplies a previously requested password.
        /// </summary>
        PasswordResponse,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Disowns an item.
        /// </summary>
        ResetItemOwner,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Sets a player's active (currently talked to) NPC.
        /// </summary>
        PlayerSetActiveNPC,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Plays a player's currently held item's animation
        /// </summary>
        PlayerItemAnimation,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates a player's mana variables. (current &amp; max mana)
        /// </summary>
        PlayerMana,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Shows a mana heal effect (blue floating numbers showing the amount of mana restored) above a player.
        /// </summary>
        PlayerManaEffect,
        /// <summary>
        /// Obsolete player suicide packet.
        /// </summary>
        [Obsolete("This packet has been removed from the game and is no longer supported.", true)]
        PlayerSuicide,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Sets the player's team.
        /// </summary>
        PlayerTeam,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Requests a sign's contents.
        /// </summary>
        SignRequest,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates the sign's contents. If received by client, also opens the sign.
        /// </summary>
        SignUpdate,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates a block's liquid properties.
        /// </summary>
        LiquidUpdate,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Notifies the client that authentication is now complete and they may spawn.
        /// </summary>
        SpawnRequest,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates a player's buffs.
        /// </summary>
        PlayerUpdateBuffs,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Spawns a special effect in the world.
        /// </summary>
        SpecialEffect,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Unlocks a door or chest
        /// </summary>
        TileUnlock,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Adds a buff to an NPC.
        /// </summary>
        NPCAddBuff,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Updates an NPC's buffs.
        /// </summary>
        NPCUpdateBuffs,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Adds a buff to a player.
        /// </summary>
        PlayerAddBuff,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Requests or updates an NPC's name.
        /// </summary>
        NPCName,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Updates the world's elements status (corruption, crimson, hallow)
        /// </summary>
        UpdateWorldElementsStatus,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Plays the player's currently held item
        /// </summary>
        PlayerPlayMusic,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Activates a toggleable wire contraption.
        /// </summary>
        PlayerActivateSwitch,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Update's an NPC's home location.
        /// </summary>
        NPCUpdateHome,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Spawns a boss or invasion.
        /// </summary>
        PlayerBeginEvent,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Networks a client's dodge.
        /// </summary>
        PlayerDodge,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Paints a tile.
        /// </summary>
        TilePaint,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Paints a wall.
        /// </summary>
        TilePaintWall,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Teleports an NPC or a player.
        /// </summary>
        EntityTeleport,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Heals another player.
        /// </summary>
        PlayerHealOther,
        /// <summary>
        /// Packet reserved for custom clients and servers.
        /// </summary>
        Custom,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Contains the player's <see cref="Guid"/>
        /// </summary>
        PlayerUUID,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Requests/Receives a chest's name.
        /// </summary>
        ChestName,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Catches an NPC.
        /// </summary>
        NPCCatch,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Releases an NPC from a player's item.
        /// </summary>
        NPCRelease,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Sends the traveling merchant's inventory.
        /// </summary>
        NPCTravelingMerchantInventory,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Teleports a player to a random location.
        /// </summary>
        PlayerTeleportationPotion,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Sends the angler's current quest.
        /// </summary>
        NPCAnglerQuest,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// <para>Notifies the server that this client completed the angler's quest.</para>
        /// For the total quests completed completion packet, see <seealso cref="PlayerAnglerQuestsCompleted"/>
        /// </summary>
        PlayerCompleteAnglerQuest,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// <para> Notifies the server how many angler quests this player has completed. </para>
        /// For a single completion packet, see <seealso cref="PlayerCompleteAnglerQuest"/>
        /// </summary>
        PlayerAnglerQuestsCompleted,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Creates a temporary animation.
        /// </summary>
        CreateTemporaryAnimation,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Reports the current invasion's progress.
        /// </summary>
        InvasionProgress,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Places a multiblock object.
        /// </summary>
        TilePlaceObject,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Updates a player's open chest.
        /// </summary>
        PlayerSyncOpenChest,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Creates a damage indicator combat text (floating numbers indicating damage or healing)
        /// </summary>
        CombatText,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Contains a subpacket for futher processing.
        /// </summary>
        NetPacket,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Updates an NPC's death tally.
        /// </summary>
        NPCUpdateTally,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates a player's stealth state.
        /// </summary>
        PlayerUpdateStealth,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Auto-places an item into the nearest applicable chest.
        /// </summary>
        AutoInsertItem,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Updates a tile entity.
        /// </summary>
        TileEntityUpdate,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Places a tile entity.
        /// </summary>
        TileEntityCreate,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Updates a dropped item's stats
        /// </summary>
        AlterItem,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Places an item frame.
        /// </summary>
        ItemFrameCreate,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Updates a dropped instanced item.
        /// </summary>
        UpdateItemInstanced,
        /// <summary>
        /// <para>Client &lt;- Server</para>
        /// Creates or updates an emote bubble.
        /// </summary>
        EmoteBubble,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Sets an NPC's extra value.
        /// </summary>
        NPCExtraValue,
        [Obsolete("This packet has been removed from the game and is no longer supported.", true)]
        Packet93,
        [Obsolete("This packet has been removed from the game and is no longer supported.", true)]
        Packet94,
        /// <summary>
        /// <para>Client -&gt; Server</para>
        /// Removes a portal.
        /// </summary>
        PortalKill,
        /// <summary>
        /// <para>Client &lt;-&gt; Server</para>
        /// Teleports a player through a portal.
        /// </summary>
        PortalTeleportPlayer,

    }
}
