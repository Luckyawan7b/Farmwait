tambahin query ini di posgre karena saya nambah 2 attribute di entity transaksi

ALTER TABLE public."transaksi"
ADD COLUMN "jumlah" integer,
ADD COLUMN "totalharga" integer;

PERLU DICATAT JUGAAA!! kalo di entity produk tuh nama atributnya "jumlahproduk" instead of jumlahstok. tapi kalo di transaksi nanti namanya "jumlah" aja ya!!
