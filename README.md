tambahin query ini di posgre karena saya nambah 2 attribute di entity transaksi

ALTER TABLE public."transaksi"
ADD COLUMN "jumlah" integer,
ADD COLUMN "totalharga" integer;
