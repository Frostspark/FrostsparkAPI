namespace Frostspark.API.Entities.Interfaces
{
    /// <summary>
    /// Represents an entity that has health, can take damage etc.
    /// </summary>
    public interface ILiving
    {
        /// <summary>
        /// Gets or sets this entity's health.
        /// </summary>
        int Health { get; set; }

        /// <summary>
        /// Hurts the entity.
        /// </summary>
        /// <param name="damage">Hitpoints of damage to deal</param>
        /// <param name="crit">Whether or not the damage should be critical</param>
        void Hurt(int damage, bool crit = false);

        /// <summary>
        /// Instantly kills the entity
        /// <para>This is different from <see cref="Entity.Remove"/> - <see cref="Kill"/> will trigger death hooks, while <see cref="Entity.Remove"/> will remove it silently.</para>
        /// </summary>
        void Kill();

        /// <summary>
        /// Heals this entity. Optional parameters define healing mode.
        /// <para></para>
        /// </summary>
        /// <param name="health">Amount of health to add (or to heal up to). 0 implies full health.</param>
        /// <param name="is_add">Specifies healing mode. A value of true means <paramref name="health"/> health will be added. A value of false means the player's health will be set to <paramref name="health"/></param>
        void Heal(int health = 0, bool is_add = false);
    }
}
