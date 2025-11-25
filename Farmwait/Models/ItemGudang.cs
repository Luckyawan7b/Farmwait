namespace Farmwait.Models
{
    // [ABSTRAKSI]
    // Abstract class tidak bisa di-instansiasi langsung (new ItemGudang() -> ERROR).
    // Ini hanya kerangka dasar.
    public abstract class ItemGudang
    {
        // [PEWARISAN]
        // Properti ini akan otomatis dimiliki oleh anak-anaknya (Pakan, Obat, Pupuk, dll)
        public int Id { get; set; }
        public string Nama { get; set; }

        // Abstract method: "Memaksa" anak class untuk membuat fungsi ini dengan cara mereka sendiri
        public abstract string GetInfoLengkap();
    }
}